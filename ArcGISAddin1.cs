using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using System.Windows.Forms;

namespace ArcMapShowGridAddin
{


    public class ShowGridAddin : ESRI.ArcGIS.Desktop.AddIns.Tool
    {
        int mouseX = 0;
        int mouseY = 0;
        int angle = 0;
        IMapDocument mapDoc;
        IPolyline line_v;
        IPolyline line_h;
        ISymbol symbol;
        DetailForm frm;
        List<IElement> addedLines = new List<IElement>();

        public ShowGridAddin()
        {

        }

        protected override void OnActivate()
        {
            if (frm == null)
            { frm = new DetailForm(); frm.clearLinesHandler = new ClearLinesDelegate(ClearLinesMethod); }
            frm.Show(); 
           
            IRgbColor rgbColor = new RgbColorClass();
            rgbColor.Red = 255;

            IColor color = rgbColor; // Implicit cast.
            ISimpleLineSymbol simpleLineSymbol = new SimpleLineSymbolClass();
            simpleLineSymbol.Color = color;

            symbol = simpleLineSymbol as ISymbol; // Explicit cast.
            mapDoc = ArcMap.Application.Document as IMapDocument;
            IActiveViewEvents_Event avevents = mapDoc.ActiveView as IActiveViewEvents_Event;
            avevents.AfterDraw += avevents_AfterDraw;
        }

        private void ClearLinesMethod()
        {
            IGraphicsContainer container = mapDoc.ActiveView as IGraphicsContainer;
            for (int i = addedLines.Count - 1; i >= 0; i--)
            {
                IElement ele = addedLines[i];
                container.DeleteElement(ele);
                addedLines.Remove(ele);
            }
        }

        protected override bool OnDeactivate()
        {
            frm.Hide();
            IActiveViewEvents_Event avevents = mapDoc.ActiveView as IActiveViewEvents_Event;
            avevents.AfterDraw -= avevents_AfterDraw;
            mapDoc.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewForeground, null, null);
            return true;
        }

        protected override void OnMouseDown(ESRI.ArcGIS.Desktop.AddIns.Tool.MouseEventArgs arg)
        {
            IPoint loc = mapDoc.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(mouseX, mouseY);
            
            IGraphicsContainer container = mapDoc.ActiveView as IGraphicsContainer;
            ILineElement lineElement_v = new LineElementClass();
            lineElement_v.Symbol = symbol as ILineSymbol;
            IElement lineElement_v_ele = lineElement_v as IElement;
            lineElement_v_ele.Geometry = line_v;

            container.AddElement(lineElement_v_ele, 0);

            ILineElement lineElement_h = new LineElementClass();
            lineElement_h.Symbol = symbol as ILineSymbol;
            IElement lineElement_h_ele = lineElement_h as IElement;
            lineElement_h_ele.Geometry = line_h;

            container.AddElement(lineElement_h_ele, 0);

            mapDoc.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);

            addedLines.Add(lineElement_v_ele);
            addedLines.Add(lineElement_h_ele);

            frm.AddPoints(loc.X, loc.Y);

        }

        void avevents_AfterDraw(IDisplay disply, esriViewDrawPhase phase)
        {
            if (phase == esriViewDrawPhase.esriViewForeground)
            {
                disply.StartDrawing(disply.hDC, (System.Int16)esriScreenCache.esriNoScreenCache);
                disply.SetSymbol(symbol);
                //Draw vertical line
                line_v = new PolylineClass();
                IPoint loc = disply.DisplayTransformation.ToMapPoint(mouseX, mouseY);
                IPointCollection4 pc_line_v = line_v as IPointCollection4;


                double radius = Math.Sqrt(Math.Pow(mapDoc.ActiveView.Extent.Width,2)+Math.Pow(mapDoc.ActiveView.Extent.Height,2));
                double rotate = angle * Math.PI / 180;
                double rotate_to = (angle + 90) * Math.PI / 180;

                IPoint fromPoint = new PointClass();
                fromPoint.X = loc.X + Math.Sin(rotate) * radius;
                fromPoint.Y = loc.Y + Math.Cos(rotate) * radius;
                pc_line_v.AddPoint(fromPoint);

                IPoint toPoint = new PointClass();
                toPoint.X = loc.X - Math.Sin(rotate) * radius;
                toPoint.Y = loc.Y - Math.Cos(rotate) * radius;
                pc_line_v.AddPoint(toPoint);

                disply.DrawPolyline(line_v as IGeometry);

                //Draw horizon line
                line_h = new PolylineClass();
                IPointCollection4 pc_line_h = line_h as IPointCollection4;

                //fromPoint = new PointClass();
                fromPoint.X = loc.X + Math.Sin(rotate_to) * radius;
                fromPoint.Y = loc.Y + Math.Cos(rotate_to) * radius;
                pc_line_h.AddPoint(fromPoint);

                //toPoint = new PointClass();
                toPoint.X = loc.X - Math.Sin(rotate_to) * radius;
                toPoint.Y = loc.Y - Math.Cos(rotate_to) * radius;
                pc_line_h.AddPoint(toPoint);

                disply.DrawPolyline(line_h as IGeometry);
                disply.FinishDrawing();
            }
        }

        protected override void OnMouseMove(ESRI.ArcGIS.Desktop.AddIns.Tool.MouseEventArgs arg)
        {
            //
            mouseX = arg.X;
            mouseY = arg.Y;
            mapDoc.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewForeground, null, null);

            
        }

        protected override void OnKeyDown(ESRI.ArcGIS.Desktop.AddIns.Tool.KeyEventArgs arg)
        {
            if(arg.KeyCode==Keys.A)
            {
                angle = (angle > 360) ? 0 : angle + 1;
                mapDoc.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewForeground, null, null);
            }
            else if (arg.KeyCode == Keys.D)
            {
                angle = (angle < 0) ? 360 : angle - 1;
                mapDoc.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewForeground, null, null);
            }
            else if (arg.KeyCode == Keys.R)
            {
                angle = 0;
                mapDoc.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewForeground, null, null);
            }
        }
    }

}
