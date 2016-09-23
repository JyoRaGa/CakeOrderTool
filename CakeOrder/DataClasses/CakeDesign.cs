using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CakeOrder.DataClasses
{
    public enum DesignEnum
    {
        Undefined = -1,
        Balloon,
        CapeAndGown,
        Celebration,
        CreamCone,
        Floral,
        FlowerGarden,
        Football,
        Frame,
        MiniCupCake,
        Spiderman,
    };

    public enum ShapeEnum
    {
        Undefined = -1,
        Round,
        Rectangle,
        Square,
        Custom,
    };

    public enum SizeEnum
    {
        Undefined = -1,
        OneThirdSheet,
        HalfSheet,
        TwoThirdSheet,
        FullSheet,
        OneOneThirdSheet,
        OneOneHalfSheet,
        DoubleSheet,
        SixInchRound,
        NineInchRound,
        CustomSize,
    };

    public enum ColorEnum
    {
        Undefined = -1,
        Blue,
        Pink,
        Yellow,
        White,
        Green,
        Chocolate,
        OffWhite,
        CustomColor
    }

    public enum FlavorEnum
    {
        Undefined = -1,
        Vanilla,
        Strawberry,
        Chocolate,
    }

    class DesignLists
    {
        public static List<CakeDesign> DefaultDesignsList { get; }
        //public static List<CakeDesign> SelectedDesignsList { get; }

        public static List<CakeShape> DefaultShapesList { get; }
        //public static List<CakeShape> SelectedShapesList { get; }

        public static List<CakeSize> DefaultSizesList { get; }
        //public static List<CakeSize> SelectedSizesList { get; }

        public static List<CakeColor> DefaultColorsList { get; }
        //public static List<CakeColor> SelectedColorsList { get; }

        public static List<CakeFlavor> DefaultFlavorsList { get; }
        //public static List<CakeFlavor> SelectedFlavorsList { get; }

        static DesignLists()
        {
            DefaultDesignsList = new List<CakeDesign>();

            #region Design List creation

            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : None",
                    DesignNum = DesignEnum.Undefined,
                    DefaultColor = ColorEnum.Blue,
                    DefaultShape = ShapeEnum.Rectangle,
                    DefaultSize = SizeEnum.HalfSheet,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.Undefined,
                    Shape = ShapeEnum.Undefined,
                    Size = SizeEnum.Undefined,
                    Flavor = FlavorEnum.Undefined,
                }
            );

            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Balloon",
                    DesignNum = DesignEnum.Balloon,
                    DefaultColor = ColorEnum.Blue,
                    DefaultShape = ShapeEnum.Rectangle,
                    DefaultSize = SizeEnum.HalfSheet,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.Blue,
                    Shape = ShapeEnum.Rectangle,
                    Size = SizeEnum.HalfSheet,
                    Flavor = FlavorEnum.Vanilla,
                }
            );
            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Cape And Gown Cake",
                    DesignNum = DesignEnum.CapeAndGown,
                    DefaultColor = ColorEnum.White,
                    DefaultShape = ShapeEnum.Rectangle,
                    DefaultSize = SizeEnum.HalfSheet,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.White,
                    Shape = ShapeEnum.Rectangle,
                    Size = SizeEnum.HalfSheet,
                    Flavor = FlavorEnum.Vanilla,
                }
            );
            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Celebration Cake",
                    DesignNum = DesignEnum.Celebration,
                    DefaultColor = ColorEnum.OffWhite,
                    DefaultShape = ShapeEnum.Round,
                    DefaultSize = SizeEnum.SixInchRound,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.OffWhite,
                    Shape = ShapeEnum.Round,
                    Size = SizeEnum.SixInchRound,
                    Flavor = FlavorEnum.Vanilla,
                }
            );
            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Cream Cone Cake",
                    DesignNum = DesignEnum.CreamCone,
                    DefaultColor = ColorEnum.Yellow,
                    DefaultShape = ShapeEnum.Round,
                    DefaultSize = SizeEnum.SixInchRound,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.Yellow,
                    Shape = ShapeEnum.Round,
                    Size = SizeEnum.SixInchRound,
                    Flavor = FlavorEnum.Vanilla,
                }
            );
            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Floral Cake",
                    DesignNum = DesignEnum.Floral,
                    DefaultColor = ColorEnum.Pink,
                    DefaultShape = ShapeEnum.Rectangle,
                    DefaultSize = SizeEnum.HalfSheet,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.Pink,
                    Shape = ShapeEnum.Rectangle,
                    Size = SizeEnum.HalfSheet,
                    Flavor = FlavorEnum.Vanilla,
                }
            );
            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Flower Garden",
                    DesignNum = DesignEnum.FlowerGarden,
                    DefaultColor = ColorEnum.Green,
                    DefaultShape = ShapeEnum.Rectangle,
                    DefaultSize = SizeEnum.HalfSheet,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.Green,
                    Shape = ShapeEnum.Rectangle,
                    Size = SizeEnum.HalfSheet,
                    Flavor = FlavorEnum.Vanilla,
                }
            );
            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Mini CupCake Cake",
                    DesignNum = DesignEnum.MiniCupCake,
                    DefaultColor = ColorEnum.Yellow,
                    DefaultShape = ShapeEnum.Round,
                    DefaultSize = SizeEnum.SixInchRound,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.Yellow,
                    Shape = ShapeEnum.Round,
                    Size = SizeEnum.SixInchRound,
                    Flavor = FlavorEnum.Vanilla,
                }
            );
            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Spiderman Cake",
                    DesignNum = DesignEnum.Spiderman,
                    DefaultColor = ColorEnum.CustomColor,
                    DefaultShape = ShapeEnum.Custom,
                    DefaultSize = SizeEnum.CustomSize,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.CustomColor,
                    Shape = ShapeEnum.Custom,
                    Size = SizeEnum.CustomSize,
                    Flavor = FlavorEnum.Vanilla,
                }
            );
            DefaultDesignsList.Add(
                new CakeDesign
                {
                    DesignName = "Design : Football Cake",
                    DesignNum = DesignEnum.Football,
                    DefaultColor = ColorEnum.CustomColor,
                    DefaultShape = ShapeEnum.Custom,
                    DefaultSize = SizeEnum.CustomSize,
                    DefaultFlavor = FlavorEnum.Vanilla,
                    Color = ColorEnum.CustomColor,
                    Shape = ShapeEnum.Custom,
                    Size = SizeEnum.CustomSize,
                    Flavor = FlavorEnum.Vanilla,
                }
            );

#endregion
#region Shape List creation
            DefaultShapesList = new List<CakeShape>();

            DefaultShapesList.Add(
                new CakeShape
                {
                    ShapeName = "Shape : Not selected",
                    ShapeNum = ShapeEnum.Undefined,
                    Enabled = true,
                }
            );

            DefaultShapesList.Add(
                new CakeShape
                {
                    ShapeName = "Shape : Round",
                    ShapeNum = ShapeEnum.Round,
                    Enabled = true,
                }
            );

            DefaultShapesList.Add(
                new CakeShape
                {
                    ShapeName = "Shape : Rectangle",
                    ShapeNum = ShapeEnum.Rectangle,
                    Enabled = true,
                }
            );

            DefaultShapesList.Add(
                new CakeShape
                {
                    ShapeName = "Shape : Square",
                    ShapeNum = ShapeEnum.Square,
                    Enabled = true,
                }
            );

            DefaultShapesList.Add(
                new CakeShape
                {
                    ShapeName = "Shape : Custom",
                    ShapeNum = ShapeEnum.Custom,
                    Enabled = true,
                }
            );

#endregion
#region Size List creation
            DefaultSizesList = new List<CakeSize>();

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : None",
                    SizeNum = SizeEnum.Undefined,
                    ShapeNum = ShapeEnum.Undefined,
                    Enabled = true,
                }
            );


            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : Six Inch",
                    SizeNum = SizeEnum.SixInchRound,
                    ShapeNum = ShapeEnum.Round,
                    Enabled = true,
                }
            );

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : Nine Inch",
                    SizeNum = SizeEnum.NineInchRound,
                    ShapeNum = ShapeEnum.Round,
                    Enabled = true,
                }
            );

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : Half Sheet",
                    SizeNum = SizeEnum.HalfSheet,
                    ShapeNum = ShapeEnum.Rectangle,
                    Enabled = true,
                }
            );

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : Full Sheet",
                    SizeNum = SizeEnum.FullSheet,
                    ShapeNum = ShapeEnum.Rectangle,
                    Enabled = true,
                }
            );

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : Double Sheet",
                    SizeNum = SizeEnum.DoubleSheet,
                    ShapeNum = ShapeEnum.Rectangle,
                    Enabled = true,
                }
            );

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : One and One Half Sheet",
                    SizeNum = SizeEnum.OneOneHalfSheet,
                    ShapeNum = ShapeEnum.Rectangle,
                    Enabled = true,
                }
            );

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : One and One Third Sheet",
                    SizeNum = SizeEnum.OneOneThirdSheet,
                    ShapeNum = ShapeEnum.Rectangle,
                    Enabled = true,
                }
            );


            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : One Third Sheet",
                    SizeNum = SizeEnum.OneThirdSheet,
                    ShapeNum = ShapeEnum.Rectangle,
                    Enabled = true,
                }
            );

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : Two Third Sheet",
                    SizeNum = SizeEnum.TwoThirdSheet,
                    ShapeNum = ShapeEnum.Square,
                    Enabled = true,
                }
            );

            DefaultSizesList.Add(
                new CakeSize
                {
                    SizeName = "Size : Custom",
                    SizeNum = SizeEnum.CustomSize,
                    ShapeNum = ShapeEnum.Custom,
                    Enabled = true,
                }
            );

            #endregion
#region Color List creation
            DefaultColorsList = new List<CakeColor>();

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : None",
                    ColorNum = ColorEnum.Undefined,
                }
            );

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : Blue",
                    ColorNum = ColorEnum.Blue,
                }
            );

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : Chocolate",
                    ColorNum = ColorEnum.Chocolate,
                }
            );

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : Green",
                    ColorNum = ColorEnum.Green,
                }
            );

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : OffWhite",
                    ColorNum = ColorEnum.OffWhite,
                }
            );

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : Pink",
                    ColorNum = ColorEnum.Pink,
                }
            );

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : White",
                    ColorNum = ColorEnum.White,
                }
            );

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : Yellow",
                    ColorNum = ColorEnum.Yellow,
                }
            );

            DefaultColorsList.Add(
                new CakeColor
                {
                    ColorName = "Color : Custom Color",
                    ColorNum = ColorEnum.CustomColor,
                }
            );

            #endregion
#region Flavor List creation
            DefaultFlavorsList = new List<CakeFlavor>();

            DefaultFlavorsList.Add(
                new CakeFlavor
                {
                    FlavorName = "Flavor : None",
                    FlavorNum = FlavorEnum.Undefined,
                }
            );

            DefaultFlavorsList.Add(
                new CakeFlavor
                {
                    FlavorName = "Flavor : Chocolate",
                    FlavorNum = FlavorEnum.Chocolate,
                }
            );

            DefaultFlavorsList.Add(
                new CakeFlavor
                {
                    FlavorName = "Flavor : Vanilla",
                    FlavorNum = FlavorEnum.Vanilla,
                }
            );

            DefaultFlavorsList.Add(
                new CakeFlavor
                {
                    FlavorName = "Flavor : Strawberry",
                    FlavorNum = FlavorEnum.Strawberry,
                }
            );
#endregion
        }

    }

    public class CakeDesign
    {
        public static CakeShape SelectedShape = new CakeShape
        {
            ShapeName = "Shape : None",
            ShapeNum = ShapeEnum.Undefined,
            Enabled = true,
            Selected = false,
        };

        public static CakeSize SelectedSize = new CakeSize
        {
            SizeName = "Size : None",
            SizeNum = SizeEnum.Undefined,
            ShapeNum = ShapeEnum.Undefined,
            Enabled = true,
            Selected = false,
        };

        public static CakeColor SelectedColor = new CakeColor
        {
            ColorName = "Color : None",
            ColorNum = ColorEnum.Undefined,
            Selected = false,
        };

        public static CakeFlavor SelectedFlavor = new CakeFlavor
        {
            FlavorName = "Flavor : None",
            FlavorNum = FlavorEnum.Undefined,
            Selected = false,
        };

        public static CakeDesign SelectedDesign = new CakeDesign
        {
            DesignName = "Design : None",
            DesignNum = DesignEnum.Undefined,
            DefaultColor = ColorEnum.Blue,
            DefaultShape = ShapeEnum.Rectangle,
            DefaultSize = SizeEnum.HalfSheet,
            DefaultFlavor = FlavorEnum.Vanilla,
            Color = ColorEnum.Undefined,
            Shape = ShapeEnum.Undefined,
            Size = SizeEnum.Undefined,
            Flavor = FlavorEnum.Undefined,
            Selected = false,
        };

        public static Dictionary<DesignEnum, string> DesignImages = new Dictionary<DesignEnum, string>();

        public string DesignName { get; set; }
        public DesignEnum DesignNum { get; set; }
        public ShapeEnum DefaultShape { get; set; }
        public ShapeEnum Shape { get; set; }
        public ColorEnum DefaultColor { get; set; }
        public ColorEnum Color { get; set; }
        public SizeEnum DefaultSize { get; set; }
        public SizeEnum Size { get; set; }
        public FlavorEnum DefaultFlavor { get; set; }
        public FlavorEnum Flavor { get; set; }
        public Image CakeImage { get; set; }
        public bool Selected { get; set; }

        static CakeDesign()
        {
            DesignImages = new Dictionary<DesignEnum, string>();
            DesignImages.Add(DesignEnum.Undefined, @"Images\Designs\CakeBackground.jpg");
            DesignImages.Add(DesignEnum.Balloon, @"Images\Designs\BalloonRectFullBlue.jpg");
            DesignImages.Add(DesignEnum.CapeAndGown, @"Images\Designs\CapAndGown.jpg");
            DesignImages.Add(DesignEnum.Celebration, @"Images\Designs\CelebrationOffWhite.jpg");
            DesignImages.Add(DesignEnum.CreamCone, @"Images\Designs\CreamCone.jpg");
            DesignImages.Add(DesignEnum.Floral, @"Images\Designs\Floral.jpg");
            DesignImages.Add(DesignEnum.FlowerGarden, @"Images\Designs\FlowerGarden.jpg");
            DesignImages.Add(DesignEnum.Football, @"Images\Designs\Football.jpg");
            DesignImages.Add(DesignEnum.Frame, @"Images\Designs\Frame.jpg");
            DesignImages.Add(DesignEnum.MiniCupCake, @"Images\Designs\MiniCupcake.jpg");
            DesignImages.Add(DesignEnum.Spiderman, @"Images\Designs\SpiderMan.jpg");
        }
    }

    public class CakeShape
    {
        public static Dictionary<ShapeEnum, string> ShapeImages = new Dictionary<ShapeEnum, string>();

        public string ShapeName { get; set; }
        public ShapeEnum ShapeNum { get; set; }
        public SizeEnum SizeNum { get; set; }
        public Image ShapeImage { get; set; }
        public bool Enabled { get; set; }
        public bool Selected { get; set; }

        static CakeShape()
        {
            ShapeImages = new Dictionary<ShapeEnum, string>();
            ShapeImages.Add(ShapeEnum.Undefined, @"Images\Designs\CakeBackground.jpg");
            ShapeImages.Add(ShapeEnum.Round, @"Images\Shapes\Round.jpg");
            ShapeImages.Add(ShapeEnum.Rectangle, @"Images\Shapes\Rectangle.jpg");
            ShapeImages.Add(ShapeEnum.Square, @"Images\Shapes\Square.jpg");
            ShapeImages.Add(ShapeEnum.Custom, @"Images\Shapes\Custom.jpg");
        }
    }

    public class CakeSize
    {
        public static Dictionary<SizeEnum, string> SizeImages = new Dictionary<SizeEnum, string>();

        public string SizeName { get; set; }
        public SizeEnum SizeNum { get; set; }
        public ShapeEnum ShapeNum { get; set; }
        public Image SizeImage { get; set; }
        public bool Enabled { get; set; }
        public bool Selected { get; set; }

        static CakeSize()
        {
            SizeImages = new Dictionary<SizeEnum, string>();
            SizeImages.Add(SizeEnum.Undefined, @"Images\Designs\CakeBackground.jpg");
            SizeImages.Add(SizeEnum.SixInchRound, @"Images\Sizes\SixInch.jpg");
            SizeImages.Add(SizeEnum.NineInchRound, @"Images\Sizes\NineInch.jpg");
            SizeImages.Add(SizeEnum.HalfSheet, @"Images\Sizes\HalfSheet.jpg");
            SizeImages.Add(SizeEnum.FullSheet, @"Images\Sizes\FullSheet.jpg");
            SizeImages.Add(SizeEnum.DoubleSheet, @"Images\Sizes\DoubleSheet.jpg");
            SizeImages.Add(SizeEnum.OneOneHalfSheet, @"Images\Sizes\OneOneHalf.jpg");
            SizeImages.Add(SizeEnum.OneOneThirdSheet, @"Images\Sizes\OneOneThird.jpg");
            SizeImages.Add(SizeEnum.OneThirdSheet, @"Images\Sizes\OneThird.jpg");
            SizeImages.Add(SizeEnum.TwoThirdSheet, @"Images\Sizes\TwoThird.jpg");
            SizeImages.Add(SizeEnum.CustomSize, @"Images\Sizes\Custom.jpg");
        }
    }


    public class CakeColor
    {
        public static Dictionary<ColorEnum, string> ColorImages = new Dictionary<ColorEnum, string>();

        public string ColorName { get; set; }
        public ColorEnum ColorNum { get; set; }
        public Image ColorImage { get; set; }
        public bool Selected { get; set; }

        static CakeColor()
        {
            ColorImages = new Dictionary<ColorEnum, string>();
            ColorImages.Add(ColorEnum.Undefined, @"Images\Designs\CakeBackground.jpg");
            ColorImages.Add(ColorEnum.Blue, @"Images\Colors\RoundBlue.jpg");
            ColorImages.Add(ColorEnum.Chocolate, @"Images\Colors\RoundChocolate.jpg");
            ColorImages.Add(ColorEnum.Green, @"Images\Colors\RoundGreen.jpg");
            ColorImages.Add(ColorEnum.OffWhite, @"Images\Colors\RoundOffWhite.jpg");
            ColorImages.Add(ColorEnum.Pink, @"Images\Colors\RoundPink.jpg");
            ColorImages.Add(ColorEnum.White, @"Images\Colors\RoundWhite.jpg");
            ColorImages.Add(ColorEnum.Yellow, @"Images\Colors\RoundYellow.jpg");
            ColorImages.Add(ColorEnum.CustomColor, @"Images\Colors\Custom.jpg");
        }
    }

    public class CakeFlavor
    {
        public static Dictionary<FlavorEnum, string> FlavorImages = new Dictionary<FlavorEnum, string>();

        public string FlavorName { get; set; }
        public FlavorEnum FlavorNum { get; set; }
        public Image FlavorImage { get; set; }
        public bool Selected { get; set; }

        static CakeFlavor()
        {
            FlavorImages = new Dictionary<FlavorEnum, string>();
            FlavorImages.Add(FlavorEnum.Undefined, @"Images\Designs\CakeBackground.jpg");
            FlavorImages.Add(FlavorEnum.Chocolate, @"Images\Flavors\Chocolate.jpg");
            FlavorImages.Add(FlavorEnum.Strawberry, @"Images\Flavors\Strawberry.jpg");
            FlavorImages.Add(FlavorEnum.Vanilla, @"Images\Flavors\Vanilla.jpg");
        }
    }
}