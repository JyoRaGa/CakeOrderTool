using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CakeOrder.DataClasses
{
    enum DesignEnum
    {
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

    enum ShapeEnum
    {
        Round,
        Rectangle,
        Square,
        Custom,
    };

    enum SizeEnum
    {
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

    enum ColorEnum
    {
        Blue,
        Pink,
        Yellow,
        White,
        Green,
        Chocolate,
        OffWhite,
        CustomColor
    }

    enum FlavorEnum
    {
        Vanilla,
        Strawberry,
        Chocolate,
    }

    class DesignLists
    {
        public static List<CakeDesign> DefaultDesignList { get; }
        //public static List<CakeDesign> SelectedDesignList { get; }

        public static List<CakeShape> DefaultShapeList { get; }
        //public static List<CakeShape> SelectedShapeList { get; }


        static DesignLists()
        {
            DefaultDesignList = new List<CakeDesign>();

            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Balloon",
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
            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Cape And Gown Cake",
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
            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Celebration Cake",
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
            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Cream Cone Cake",
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
            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Floral Cake",
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
            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Flower Garden",
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
            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Mini CupCake Cake",
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
            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Spiderman Cake",
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
            DefaultDesignList.Add(
                new CakeDesign
                {
                    DesignName = "Football Cake",
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

            DefaultShapeList = new List<CakeShape>();

            DefaultShapeList.Add(
                new CakeShape
                {
                    ShapeName = "Round",
                    ShapeNum = ShapeEnum.Round,
                }
            );

            DefaultShapeList.Add(
                new CakeShape
                {
                    ShapeName = "Rectangle",
                    ShapeNum = ShapeEnum.Rectangle,
                }
            );

            DefaultShapeList.Add(
                new CakeShape
                {
                    ShapeName = "Square",
                    ShapeNum = ShapeEnum.Square,
                }
            );

            DefaultShapeList.Add(
                new CakeShape
                {
                    ShapeName = "Custom",
                    ShapeNum = ShapeEnum.Custom,
                }
            );
        }

    }

    class CakeDesign
    {
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

        static CakeDesign()
        {
            DesignImages = new Dictionary<DesignEnum, string>();
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

    class CakeShape
    {
        public static Dictionary<ShapeEnum, string> ShapeImages = new Dictionary<ShapeEnum, string>();

        public string ShapeName { get; set; }
        public ShapeEnum ShapeNum { get; set; }
        public Image ShapeImage { get; set; }

        static CakeShape()
        {
            ShapeImages = new Dictionary<ShapeEnum, string>();
            ShapeImages.Add(ShapeEnum.Round, @"Images\Shapes\Round.jpg");
            ShapeImages.Add(ShapeEnum.Rectangle, @"Images\Shapes\Rectangle.jpg");
            ShapeImages.Add(ShapeEnum.Square, @"Images\Shapes\Square.jpg");
            ShapeImages.Add(ShapeEnum.Custom, @"Images\Shapes\Custom.jpg");
        }
    }

}