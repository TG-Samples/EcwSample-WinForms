using System;
using System.Windows.Forms;
using ThinkGeo.MapSuite.Layers;
using ThinkGeo.MapSuite.WinForms;

namespace ThinkGeo.MapSuite.Samples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            winformsMap1.MapUnit = GeographyUnit.DecimalDegree;

            LayerOverlay overlay = new LayerOverlay();

            EcwRasterLayer ecwRasterLayer = new EcwRasterLayer("../../App_Data/World.ecw");
            overlay.Layers.Add(ecwRasterLayer);

            winformsMap1.Overlays.Add(overlay);

            ecwRasterLayer.Open();
            winformsMap1.CurrentExtent = ecwRasterLayer.GetBoundingBox();

            winformsMap1.Refresh();
        }
    }
}