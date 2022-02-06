using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCrop.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCrop.ImageLocation = @"./Resources/crop.png";
            pbRotate.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRotate.ImageLocation = @"./Resources/rotate.png";
            pbRgb.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRgb.ImageLocation = @"./Resources/rgb.png";
            pbSaturation.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSaturation.ImageLocation = @"./Resources/saturation.png";
            pbBrightness.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBrightness.ImageLocation = @"./Resources/brightness.png";

            saturationLabel.SizeMode = PictureBoxSizeMode.StretchImage;
            saturationLabel.ImageLocation = @"./Resources/saturation.png";
            brightnessLabel.SizeMode = PictureBoxSizeMode.StretchImage;
            brightnessLabel.ImageLocation = @"./Resources/brightness.png";

            rotate180.SizeMode = PictureBoxSizeMode.StretchImage;
            rotate180.ImageLocation = @"./Resources/180.png";
            rotate90.SizeMode = PictureBoxSizeMode.StretchImage;
            rotate90.ImageLocation = @"./Resources/90.png";
            rotate270.SizeMode = PictureBoxSizeMode.StretchImage;
            rotate270.ImageLocation = @"./Resources/270.png";

            pbTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTxt.ImageLocation = @"./Resources/txt.png";


            pbUndo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUndo.ImageLocation = @"./Resources/undo.png";
            pbRedo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRedo.ImageLocation = @"./Resources/redo.png";

            getControls();
        }
        String fileName = "";
        Boolean pictureboxValue = false;
        Boolean mouseClicked;
        Point startPoint = new Point();
        Point endPoint = new Point();
        Rectangle rectCropArea;
        Bitmap targetBitmap;
        Boolean rgb = false,txtA=false, crop = false, bright = false, saturat = false, rotate = false;
        List<Image> images;
        int index = 0 ;
        int mouseX, mouseY;

        public void getControls()
        {
             saturationPanel.Visible = false;
             cropPanel.Visible = false;
             brightnessPanel.Visible = false;
             rgbPanel.Visible = false;
             rotatePanel.Visible = false;
             txtPanel.Visible = false;

            if (pictureboxValue)
             {
                if (rgb)
                {
                    rgbPanel.Visible = true;
                    animation.Text = "RGB(Red,Green,Blue)";
                }
                else if (crop)
                {
                    cropPanel.Visible = true;
                    animation.Text = "Draw Rectangle on Area to Crop.";
                }
                else if (bright)
                {
                   brightnessPanel.Visible = true;
                   animation.Text = "Brightness Control";
                }
                else if (saturat)
                {
                    saturationPanel.Visible = true;
                    animation.Text = "Saturation Control";
                }
                else if (rotate)
                {
                    rotatePanel.Visible = true;
                    animation.Text = "Rotate Image";
                }
                else if (txtA)
                {
                    txtPanel.Visible = true;
                    animation.Text = "Draw Rectangle on Image and Click submit to Draw Text on Image.";
                }

                rgb = false;
                crop = false;
                bright = false;
                saturat = false;
                rotate = false;
                txtA = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            DialogResult command = openFileDialog1.ShowDialog();
            if (command == DialogResult.OK)
            {
                images = new List<Image>();
                index = 0;
                images.Add(Image.FromFile(openFileDialog1.FileName));
                fileName = openFileDialog1.SafeFileName;
                pictureBox1.Image = images[index];
                pictureboxValue = true;
                animation.Text = "You can access Controls.";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureboxValue)
            {
                saveFileDialog1.Filter = "Png|*.png|Jpg|*.jpg|Jpeg|*.jpeg";
                saveFileDialog1.FileName = fileName;
                ImageFormat format = ImageFormat.Jpeg;
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string extension = Path.GetExtension(saveFileDialog1.FileName);
                    switch (extension)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                    }
                    pictureBox1.Image.Save(saveFileDialog1.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Please load an image !");
            }
        }

        public void reload()
        {
            pictureBox1.Image = images[index];
        }

        public void changeImage(ColorMatrix colorMatrix)
        {
            Image pImage = pictureBox1.Image;
            Bitmap bmp = new Bitmap(pImage.Width, pImage.Height);
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.SetColorMatrix(colorMatrix);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(pImage, new Rectangle(0, 0, pImage.Width, pImage.Height), 0, 0, pImage.Width, pImage.Height, GraphicsUnit.Pixel, imageAttr);
            g.Dispose();
            pictureBox1.Image = bmp;
        }

        public void changeColor()
        {
            reload();
            float changered = redBar.Value * 0.05f;
            float changegreen = greenBar.Value * 0.05f;
            float changeblue = blueBar.Value * 0.05f;
            float bright = brightnessBar.Value * 0.05f;
			float satur = saturationBar.Value * 0.02f;
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
			new float[]{1+changered+satur,changered*satur,changered*satur,0,0},
            new float[]{changegreen*satur, 1+changegreen+satur,changegreen*satur,0,0},
            new float[]{changeblue*satur,changeblue*satur, 1+changeblue+satur, 0,0},
            new float[]{0,0,0,1,0},
            new float[]{bright,bright,bright,0,1}
            });
            changeImage(colorMatrix);
        }
        
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;

            if (endPoint.X != -1)
            {
                Point currentPoint = new Point(e.X, e.Y);
            }
            endPoint.X = -1;
            endPoint.Y = -1;
            startPoint.X = -1;
            startPoint.Y = -1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;

            startPoint.X = e.X;
            startPoint.Y = e.Y;

            endPoint.X = -1;
            endPoint.Y = -1;

            rectCropArea = new Rectangle(new Point(e.X, e.Y), new Size());
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point ptCurrent = new Point(e.X, e.Y);

            if (mouseClicked)
            {
                endPoint = ptCurrent;
                if (e.X > startPoint.X && e.Y > startPoint.Y)
                {
                    rectCropArea.Width = e.X - startPoint.X;
                    rectCropArea.Height = e.Y - startPoint.Y;
                }
                else if (e.X < startPoint.X && e.Y > startPoint.Y)
                {
                    rectCropArea.Width = startPoint.X - e.X;
                    rectCropArea.Height = e.Y - startPoint.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = startPoint.Y;
                }
                else if (e.X > startPoint.X && e.Y < startPoint.Y)
                {
                    rectCropArea.Width = e.X - startPoint.X;
                    rectCropArea.Height = startPoint.Y - e.Y;
                    rectCropArea.X = startPoint.X;
                    rectCropArea.Y = e.Y;
                }
                else
                {
                    rectCropArea.Width = startPoint.X - e.X;
                    rectCropArea.Height = startPoint.Y - e.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = e.Y;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (btnCropSelected.Visible || btnSubmit.Visible)
            {
                Pen drawLine = new Pen(Color.Red);
                drawLine.DashStyle = DashStyle.Dash;
                e.Graphics.DrawRectangle(drawLine, rectCropArea);
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            rotate = true;
            getControls();
        }


        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureboxValue)
            {
                pictureBox1.Image = images[0];
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void redbar_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void greenbar_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void bluebar_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void brightnessbar_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void saturation_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void pbCrop_Click(object sender, EventArgs e)
        {
            crop = true;
            getControls();
        }

        private void pbRotate_Click(object sender, EventArgs e)
        {
            rotate = true;
            getControls();
        }

        private void pbRgb_Click(object sender, EventArgs e)
        {
            rgb = true;
            getControls();
        }

        private void pbSaturation_Click(object sender, EventArgs e)
        {
            saturat = true;
            getControls();
        }

        private void pbBrightness_Click(object sender, EventArgs e)
        {
            bright = true;
            getControls();
        }

        private void btnCropSelected_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            targetBitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Bitmap sourceBitmap = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(targetBitmap);

            g.DrawImage(sourceBitmap, new Rectangle(0, 0, pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height), rectCropArea, GraphicsUnit.Pixel);
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = targetBitmap;
                images.Add(targetBitmap);               
                index++;
            }
            rectCropArea = new Rectangle(new Point(0,0), new Size());
        }

        private void rotate90_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Refresh();
        }

        private void rotate270_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pictureBox1.Refresh();
        }

        private void rotate180_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            mouseX = p.X;
            mouseY = p.Y;  
        }

        private void pbTxt_Click(object sender, EventArgs e)
        {
            txtA = true;
            getControls();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Bitmap sourceBitmap = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(sourceBitmap);
            Font font = fontDialog1.Font;
            PointF firstLocation = new PointF(rectCropArea.X, rectCropArea.Y);
            g.DrawString(writingTxt.Text, font, new SolidBrush(fontDialog1.Color), firstLocation);
            pictureBox1.Image = sourceBitmap;
            images.Add(sourceBitmap);
            index++;
            rectCropArea = new Rectangle(new Point(0, 0), new Size());
            pictureBox1.Refresh();
        }

        private void pbUndo_Click(object sender, EventArgs e)
        {
            if(pictureboxValue){
                if (index > 0 )
                {
                    index--;
                }
                pictureBox1.Image = images[index];
            }
        }

        private void pbRedo_Click(object sender, EventArgs e)
        {
            if (pictureboxValue)
            {
                if (index < (images.Count - 1))
                {
                    index++;
                }
                pictureBox1.Image = images[index];
            }
        }

        private void pbUndo_MouseHover(object sender, EventArgs e)
        {
            toolBar.ShowAlways = true;
            toolBar.SetToolTip(pbUndo, "Undo");  
        }

        private void pbRedo_MouseHover(object sender, EventArgs e)
        {
            toolBar.ShowAlways = true;
            toolBar.SetToolTip(pbRedo, "Redo"); 
        }

        private void pbCrop_MouseHover(object sender, EventArgs e)
        {
            toolBar.ShowAlways = true;
            toolBar.SetToolTip(pbCrop, "Crop"); 
        }

        private void pbRotate_MouseHover(object sender, EventArgs e)
        {
            toolBar.ShowAlways = true;
            toolBar.SetToolTip(pbRotate, "Rotate"); 
        }

        private void pbRgb_MouseHover(object sender, EventArgs e)
        {
            toolBar.ShowAlways = true;
            toolBar.SetToolTip(pbRgb, "RGB"); 
        }

        private void pbSaturation_MouseHover(object sender, EventArgs e)
        {
            toolBar.ShowAlways = true;
            toolBar.SetToolTip(pbSaturation, "Saturation"); 
        }

        private void pbBrightness_MouseHover(object sender, EventArgs e)
        {
            toolBar.ShowAlways = true;
            toolBar.SetToolTip(pbBrightness, "Brightness"); 
        }

        private void pbTxt_MouseHover(object sender, EventArgs e)
        {
            toolBar.ShowAlways = true;
            toolBar.SetToolTip(pbTxt, "Edit Text"); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 5;
            animation.Left = 200;
            this.KeyPreview = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation.Left > this.Width)
            {
                animation.Left = -20;
            }
            else {
                animation.Left += 1 ; 
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
            {
                pbUndo_Click(sender, new EventArgs());
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Y)
            {
                pbRedo_Click(sender, new EventArgs());
            }
   
        }
    }
}
