namespace Recipe_Mk.IV
{
    partial class frmRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRecipe = new System.Windows.Forms.TabPage();
            this.btnRecipeGo = new System.Windows.Forms.Button();
            this.numericUpDownPeople = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPeopleNumber = new System.Windows.Forms.Label();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.tabPageIngredients = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOutGo = new System.Windows.Forms.Button();
            this.numericUpDownOutPeople = new System.Windows.Forms.NumericUpDown();
            this.lblNumberPeople = new System.Windows.Forms.Label();
            this.richTextBoxUnitsOut = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAmountOut = new System.Windows.Forms.RichTextBox();
            this.richTextBoxIngredientOut = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).BeginInit();
            this.tabPageIngredients.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutPeople)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(173, 72);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 113;
            this.btnGo.Text = "Add";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recipe Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, -62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, -62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 116;
            this.label3.Text = "Amount";
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m",
            "km",
            "mg",
            "g",
            "kg",
            "t",
            "s",
            "°C",
            "m²",
            "ha",
            "km²",
            "mL",
            "cm³",
            "L",
            "m³",
            "m/s",
            "km/h",
            "kg/m³",
            "N",
            "kN",
            "Pa",
            "hPa",
            "kPa",
            "mB",
            "B",
            "W",
            "kW",
            "J",
            "kJ",
            "MJ",
            "kWh",
            "mA",
            "A",
            "in",
            "ft",
            "yd",
            "mi",
            "nmi",
            "sq in",
            "sq ft",
            "sq yd",
            "sq mi",
            "fl oz",
            "qt",
            "gal",
            "oz",
            "lb",
            "qtr",
            "cwt",
            "ton",
            "° F",
            "Ra"});
            this.comboBoxUnits.Location = new System.Drawing.Point(173, 40);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(76, 26);
            this.comboBoxUnits.TabIndex = 82;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(101, 40);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(61, 24);
            this.numericUpDownAmount.TabIndex = 81;
            // 
            // txtIngredients
            // 
            this.txtIngredients.AutoCompleteCustomSource.AddRange(new string[] {
            "Abalone",
            "Absinthe",
            "Achar",
            "Acidulated Water",
            "Ackee",
            "Acorn Squash",
            "Adobo",
            "Advieh",
            "African Birdseye Chile Peppers",
            "Agar",
            "Aioli",
            "Ajowan",
            "Al Dente",
            "Ale",
            "Aleppo Pepper",
            "Alfalfa Sprouts",
            "Alfredo Sauce",
            "Alitame",
            "Alize Liqueur",
            "Alligator",
            "Allspice",
            "Almonds",
            "Almond Bark",
            "Almond Butter",
            "Almond Extract",
            "Almond Paste",
            "Alum",
            "Amaranth",
            "Amarena Cherries",
            "Amaretti",
            "Amaretto",
            "Amarula Cream Liqueur",
            "Amchoor Powder",
            "Amla",
            "Ammonium Bicarbonate",
            "Ancho Chile Peppers",
            "Anchovette",
            "Anchovies",
            "Anchovy Paste",
            "Andouille Sausage",
            "Angelica",
            "Anise",
            "Annatto Seeds",
            "Apples",
            "Apple Butter",
            "Apple Pie Spice",
            "Applesauce",
            "Apricots",
            "Aquavit",
            "Arak",
            "Arborio Rice",
            "Argan Oil",
            "Arrowroot",
            "Artichokes",
            "Artificial Sweetener",
            "Arugula",
            "Asadero",
            "Asafetida",
            "Asiago Cheese",
            "Asparagus",
            "Aspic",
            "Avocados",
            "Azuki Beans",
            "Baba",
            "Baba Ghanoush",
            "Babaco",
            "Babka",
            "Baby Kiwi",
            "Baby Marrows",
            "Bacon",
            "Bacon Grease",
            "Bagels",
            "Bagna Cauda",
            "Bagoong",
            "Baguette",
            "Baharat",
            "Bake Blind",
            "Baking Powder",
            "Baking Soda",
            "Baklava",
            "Balmain Bug",
            "Balsamic Vinegar",
            "Bamboo Shoots",
            "Bananas",
            "Bangers",
            "Bannocks",
            "Banon Cheese",
            "Barbecue Sauce",
            "Barberries",
            "Bard",
            "Barley",
            "Barley Sugar",
            "Baron",
            "Basil",
            "Basket Cheese",
            "Basmati Rice",
            "Bass",
            "Bay Leaves",
            "Beans",
            "Bean Sauce",
            "Bean Sprouts",
            "Bean Threads",
            "Beat",
            "Bechamel",
            "Beef",
            "Beef Round Cuts",
            "Beer",
            "Beer Cheese",
            "Beer Sticks",
            "Beets",
            "Bel Paese",
            "Bento",
            "Berbere",
            "Berries",
            "Beurre Blanc",
            "Beurre Manie",
            "Beurre Manie",
            "Biltong",
            "Biscuit Mix",
            "Bisque",
            "Bitter Melon",
            "Black Beans",
            "Black Kale",
            "Black Olives",
            "Black-Eyed Peas",
            "Blackberries",
            "Blanch",
            "Blue Cheese",
            "Blueberries",
            "Boerewors",
            "Boil",
            "Bok Choy",
            "Bombay Duck",
            "Bon Appetit Seasoning",
            "Borage",
            "Borscht",
            "Bottarga",
            "Bouillon",
            "Bouquet Garni",
            "Bourbon",
            "Boursin Cheese",
            "Braai",
            "Braise",
            "Brandy",
            "Brazil Nuts",
            "Breadcrumbs",
            "Breadfruit",
            "Bresaola",
            "Brewer\'s Yeast",
            "Brick Cheese",
            "Broccoli",
            "Broccoli Raab",
            "Broil",
            "Broth",
            "Brown Rice",
            "Brown Sugar",
            "Brunoise",
            "Bruschetta",
            "Brussels Sprouts",
            "Buckwheat",
            "Buckwheat Groats",
            "Buerre Manie",
            "Buerre Manie",
            "Bulgur Wheat",
            "Bundt Pan",
            "Butter",
            "Buttermilk",
            "Buxton Blue Cheese",
            "Cabbage",
            "Cacao",
            "Cachaca",
            "Cactus",
            "Caerphilly",
            "Calabaza",
            "Callaloo",
            "Calvados",
            "Campden Tablets",
            "Canadian Bacon",
            "Candy Making Temperatures",
            "Candy Thermometers",
            "Cannellini Beans",
            "Canola Oil",
            "Cantaloupes",
            "Cape Gooseberries",
            "Capers",
            "Cappuccino Latte",
            "Capsicums",
            "Carambola",
            "Caramelize",
            "Caraway Seeds",
            "Carboy",
            "Cardamom",
            "Carob",
            "Carrageen",
            "Carrots",
            "Cashew Nut",
            "Cassava",
            "Casserole",
            "Catfish",
            "Caul",
            "Cauliflower",
            "Caviar",
            "Cayenne Pepper",
            "Celeriac",
            "Celery",
            "Celery Seeds",
            "Chai",
            "Chambord",
            "Champagne Yeast",
            "Chard",
            "Chaurice Sausage",
            "Chayote",
            "Cheddar Cheese",
            "Cheese",
            "Cheesecloth",
            "Chendol",
            "Cherimoya",
            "Cherries",
            "Chervil",
            "Cheshire Cheese",
            "Chestnuts",
            "Chickens",
            "Chicken Livers",
            "Chickpeas",
            "Chicory",
            "Chiffonade",
            "Chile Peppers",
            "Chili Powder",
            "Chili Sauce",
            "Chinese Cabbage",
            "Chinese Dates",
            "Chipotle Peppers",
            "Chives",
            "Chocolate",
            "Chowder",
            "Chutney",
            "Cider",
            "Cider Vinegar",
            "Cilantro",
            "Cinnamon",
            "Citron",
            "Citrus Oils",
            "Clafouti",
            "Clams",
            "Clarified Butter",
            "Clarify",
            "Cloves",
            "Cocoa Powder",
            "Coconuts",
            "Coconut Milk Or Cream",
            "Coconut Oil",
            "Cod",
            "Coffee",
            "Colby",
            "Common Container Sizes",
            "Confit",
            "Cookies",
            "Cool Whip",
            "Copha",
            "Coriander",
            "Corn",
            "Corn Flour",
            "Corn Syrup",
            "Corned Beef",
            "Cornichons",
            "Cornish Yarg Cheese",
            "Cornmeal",
            "Cornstarch",
            "Cottage Cheese",
            "Cottage Roll",
            "Coulis",
            "Couscous",
            "Crabs",
            "Craisins",
            "Cranberries",
            "Cranberry Bean",
            "Crayfish",
            "Cream Cheese",
            "Cream Of Coconut",
            "Cream Of Tartar",
            "Cream Of Wheat",
            "Cream, To",
            "Crema De Leche",
            "Creme Brulee",
            "Creme De Cacao",
            "Creme De Cassis",
            "Creme De Menthe",
            "Creme Fraiche",
            "Cremini Mushrooms",
            "Creole Sausage",
            "Crock Pot",
            "Crostini",
            "Croutons",
            "Crozzled",
            "Crystallized Ginger",
            "Cucumbers",
            "Cucuzza",
            "Cumin",
            "Curacao",
            "Currants",
            "Curry Leaves",
            "Curry Paste",
            "Curry Powder",
            "Custard",
            "Cut In",
            "Dash",
            "Dates",
            "Date Sugar",
            "Deglaze",
            "Demi-Glace",
            "Derby Cheese",
            "Desiccated",
            "Desserts",
            "Dhania-Jeera Powder",
            "Dice",
            "Dill",
            "Dovedale Cheese",
            "Dragees",
            "Dredge",
            "Dried Leeks",
            "Dripping",
            "Duck",
            "Dumpling",
            "Durian",
            "Dutch Oven",
            "Eau De Vie",
            "Eclairs",
            "Edam",
            "Edamame",
            "Eels",
            "Eggs",
            "Egg Substitutes",
            "Eggplants",
            "Elderberries",
            "Endive",
            "English Muffins",
            "English Mustard",
            "Epazote",
            "Erythritol",
            "Escalopes",
            "Falafel",
            "Falernum",
            "Farina",
            "Farmer Cheese",
            "Fava Beans",
            "Feet",
            "Feijoa",
            "Fennel",
            "Fennel Seeds",
            "Fenugreek",
            "Fermented Black Beans",
            "Feta Cheese",
            "Figs",
            "File Powder",
            "Finnan Haddie",
            "Firm-Ball Stage",
            "Fish Sauce",
            "Fish Slice",
            "Five-Spice Powder",
            "Flageolet",
            "Flax Seed",
            "Flounder",
            "Flour",
            "Focaccia",
            "Foie Gras",
            "Fold",
            "Fond",
            "Fontina Cheese",
            "Forcemeat",
            "Frangipane",
            "French Fries",
            "French-Style Green Beans",
            "Fried Rice Seasoning",
            "Frisee",
            "Fructose",
            "Frying Pan",
            "Galangal",
            "Ganache",
            "Garlic",
            "Garlic Powder",
            "Gelatin",
            "Gelatinized Starch",
            "Ghee",
            "Ginger",
            "Ginger Ale",
            "Ginger Beer",
            "Ginger Syrup",
            "Ginkgo Nut",
            "Glace De Viande",
            "Gloucester",
            "Gluten",
            "Gluten-Free Brand Names",
            "Goji Berry",
            "Golden Syrup",
            "Geese",
            "Gooseberries",
            "Gorgonzola",
            "Gouda",
            "Graham Crackers",
            "Grains Of Paradise",
            "Gram Flour",
            "Grand Marnier",
            "Granola",
            "Grapes",
            "Grapefruits",
            "Grating Cheese",
            "Great Northern Beans",
            "Green Beans",
            "Green Kern",
            "Green Onions",
            "Greens",
            "Grits",
            "Grouper",
            "Gruyere",
            "Guanbana",
            "Guavas",
            "Gumbo",
            "Habanero Chilies",
            "Haddock",
            "Half-And-Half",
            "Halibut",
            "Ham",
            "Ham Hock",
            "Hamburger",
            "Hard Cheese",
            "Harissa",
            "Hash Browns",
            "Havarti",
            "Hawaij ",
            "Hazelnuts",
            "Hearts Of Palm",
            "Heavy Cream",
            "Heirloom Weights & Measurements",
            "Herbs",
            "Herbsaint",
            "Herring",
            "High Altitude Adjustment For Cookies",
            "High Altitude Adjustment For Deep Fat Frying",
            "High Altitude Baking Quick Breads",
            "Hispanic Cheese",
            "Hoisin Sauce",
            "Hoja Santa",
            "Hoki",
            "Hominy",
            "Honey",
            "Honeydew Melons",
            "Horseradish",
            "Hot Sauce",
            "Huckleberries",
            "Hundred-Year Eggs",
            "Hungarian Wax Chile",
            "Hyssop",
            "I Can\'t Believe It\'s Not Butter",
            "Ice Cream",
            "Ice Wine",
            "Icing Sugar",
            "Indian Pudding",
            "Indienne, À L\'",
            "Infusion",
            "Insalata",
            "Instant Espresso",
            "Instant Potato Flakes",
            "Invert Sugar",
            "Irish Coffee",
            "Irish Cream Liqueur",
            "Irish Mist",
            "Isinglass",
            "Jack Cheese",
            "Jaggery",
            "Jambalaya",
            "Jamon Serrano",
            "Jamun",
            "Jelly Beans",
            "Jelly Roll",
            "Jelly Tots",
            "Jerusalem Artichokes",
            "Jicama",
            "Joint",
            "Jowl",
            "Kabsa Spice Mix",
            "Kaffir Lime",
            "Kahlua",
            "Kalamata Olives",
            "Kale",
            "Kamaboko",
            "Kasha",
            "Kashk",
            "Ketchup",
            "Ketjap Manis",
            "Kewra Essence",
            "Kewra Water",
            "Khus Essence",
            "Kidney Beans",
            "Kielbasa",
            "Kirsch",
            "Kitchen Bouquet",
            "Kiwi Fruit",
            "Kohlrabi",
            "Konfyt",
            "Kosher",
            "Kudzu",
            "Kugel",
            "Kumquats",
            "Lactose-Free Brand Names",
            "Ladyfingers",
            "Lamb",
            "Lambsquarters",
            "Lampreys",
            "Lancashire Cheese",
            "Lardons",
            "Lavender",
            "Lecithin",
            "Leeks",
            "Lefse",
            "Lemons",
            "Lemon Balm",
            "Lemon Grass",
            "Lemon Juice",
            "Lemon Peel",
            "Lentils",
            "Lettuce",
            "Li Hing Mui ",
            "Liaison",
            "Light Cream",
            "Lima Beans",
            "Limes",
            "Lingcod",
            "Litchi",
            "Liver",
            "Lobsters",
            "Longans",
            "Loquat",
            "Lotus",
            "Lovage",
            "Lumpia Wrappers",
            "Macadamia Nut Butter",
            "Macaroni",
            "Mace",
            "Mackerel",
            "Madeira",
            "Mahi Mahi",
            "Mahleb",
            "Malt Vinegar",
            "Malta",
            "Mandarin Oranges",
            "Mange-Tout",
            "Mangoes",
            "Mangosteen",
            "Manzanilla Olives",
            "Maple Syrup",
            "Maraschino Cherries",
            "Margarine",
            "Marjoram",
            "Marmalade",
            "Marsala",
            "Marshmallows",
            "Marula",
            "Marzipan",
            "Masa Harina",
            "Masala",
            "Masarepa",
            "Mascarpone",
            "Matignon",
            "Matzo Meal",
            "Mayonnaise",
            "Meat: Safe Cooking Temperatures",
            "Melons",
            "Meringue Powder",
            "Mesclun",
            "Mettwursts",
            "Milk",
            "Mimolette Cheese",
            "Mince",
            "Mini Babybel Light",
            "Mint",
            "Miracle Whip Dressing",
            "Mirepoix",
            "Miso",
            "Mixed Spice",
            "Mizuna",
            "Moambé Sauce",
            "Molasses",
            "Monkfish",
            "Monosodium Glutamate",
            "Moo Shu Wrappers",
            "Morels",
            "Moreton Bay Bug",
            "Moringa",
            "Mortadella",
            "Mostaccioli",
            "Mozzarella",
            "Mrs Dash\'s Fiesta Lime Salt-Free Seasoning",
            "Muddle",
            "Mugwort",
            "Mung Beans",
            "Muscadine Grape",
            "Muscovado Sugar",
            "Muscovy Duck",
            "Mushrooms",
            "Muskmelons",
            "Mussels",
            "Mustard, Prepared",
            "Mustard, Seed And Powder",
            "Nasturtium",
            "Navy Beans",
            "Nectarines",
            "Nigella Seeds",
            "Nopales",
            "Nori",
            "O\'brien Potatoes",
            "Oamc",
            "Oatmeal",
            "Octopus",
            "Offal",
            "Okra",
            "Olives",
            "Olive Oil",
            "Onions",
            "Onion Powder",
            "Oranges",
            "Orange Flower Water",
            "Orange Peel",
            "Oregano",
            "Orgeat Syrup",
            "Oven Temperatures",
            "Oyster Sauce",
            "Palm Oil",
            "Palm Sugar",
            "Pancetta",
            "Panir",
            "Panko",
            "Panna Cotta",
            "Papayas",
            "Paprika",
            "Parboil",
            "Parchment Paper",
            "Parmesan Cheese",
            "Parsley",
            "Parsnips",
            "Passion Fruit",
            "Pasta",
            "Pasta Filata Cheese",
            "Pastis",
            "Paysanne",
            "Peas",
            "Pea Beans",
            "Peaches",
            "Peanuts",
            "Peanut Butter",
            "Pears",
            "Pecans",
            "Pelargonium Citronellum",
            "Peppadew Peppers",
            "Pepper",
            "Perch",
            "Periwinkles",
            "Persimmons",
            "Pesto",
            "Pheasants",
            "Phyllo Dough",
            "Pickles",
            "Pickle Crisp Granules",
            "Pickling Lime",
            "Pico De Gallo",
            "Pie Melon",
            "Pie Servers",
            "Pierogies",
            "Pig\'s Cheek",
            "Pig\'s Feet",
            "Pike",
            "Piloncillo",
            "Pimiento",
            "Pinch",
            "Pine Nuts",
            "Pineapples",
            "Pink Beans",
            "Pinto Beans",
            "Pistachios",
            "Plantains",
            "Plastic Wrap",
            "Plums",
            "Plum Tomatoes",
            "Plumcots",
            "Poach",
            "Polenta",
            "Pomegranates",
            "Pomegranate Molasses",
            "Pomelos",
            "Pomona\'s Universal Pectin ",
            "Pompano",
            "Ponzu",
            "Poppy Seeds",
            "Porcini",
            "Pork",
            "Portabellas",
            "Potatoes",
            "Potato Chips",
            "Potato Starch",
            "Poultry Seasoning",
            "Poussin",
            "Powdered Sugar",
            "Prawns",
            "Preheat",
            "Preserves",
            "Preserved Lemon",
            "Processed Cheese",
            "Proof",
            "Prosciuttini",
            "Prosciutto",
            "Provolone",
            "Prunes",
            "Pudding Mixes",
            "Puff Pastries",
            "Pulses",
            "Pumpkins",
            "Pumpkin Pie Spice",
            "Pumpkin Seeds",
            "Purslane",
            "Quail",
            "Quark",
            "Quenelles",
            "Quesadilla",
            "Queso",
            "Quetsch",
            "Quince",
            "Quinoa",
            "Quorn",
            "Rabbits",
            "Radiatore",
            "Radicchio",
            "Radishes",
            "Raisins",
            "Rambutan",
            "Ramps",
            "Ras El Hanout",
            "Raspberries",
            "Raw Sugar",
            "Recado Rojo",
            "Recaito",
            "Red Beans",
            "Red Cabbage",
            "Red Chile Powder",
            "Red Leicester",
            "Red Pepper Flakes",
            "Red Snapper",
            "Remoulade",
            "Rhubarb",
            "Rice",
            "Rice Paddy Herb",
            "Rice Paper",
            "Rice Sticks",
            "Rice Vermicelli",
            "Rice Vinegar",
            "Rice Wines",
            "Ricotta Cheese",
            "Romaine Lettuce",
            "Romano Cheese",
            "Rookworst",
            "Rose Essense",
            "Rose Water",
            "Rosemary",
            "Rotel Tomatoes",
            "Rotisserie",
            "Roux",
            "Rum",
            "Rusks",
            "Saffron",
            "Sage",
            "Sago",
            "Salmon",
            "Salsa",
            "Salsify",
            "Salt",
            "Salt Pork",
            "Sambal",
            "Sand Dab",
            "Sandwich",
            "Sardines",
            "Satay",
            "Sauerkraut",
            "Saunf",
            "Sausages",
            "Saute",
            "Savory",
            "Sazon",
            "Scald",
            "Scallops",
            "Scaloppine",
            "Scotch Bonnet Chiles",
            "Scoville Chart",
            "Scrapple",
            "Screwpine Leaves",
            "Sea Cucumbers",
            "Sear",
            "Seed",
            "Seitan",
            "Semi-Hard Cheese",
            "Semisweet Chocolate",
            "Semolina",
            "Sesame Seeds",
            "Seville Orange",
            "Shallots",
            "Sherry",
            "Shitakes",
            "Shortening",
            "Shrimp",
            "Shrimp Paste",
            "Shropshire Blue",
            "Simmer",
            "Slipper Lobster",
            "Smelt",
            "Smoke Seasoning",
            "Smoked Salmon",
            "Snap Peas",
            "Snapper",
            "Snoek",
            "Snow Peas",
            "Soba",
            "Soba Tsuyu",
            "Soda Crackers",
            "Soft Cheese",
            "Soft-Shell Crabs",
            "Sole",
            "Somen",
            "Sorghum",
            "Sorrel",
            "Souffle",
            "Sour Cream",
            "Soy Sauce",
            "Soybeans",
            "Soymilk",
            "Spaetzle",
            "Spaghetti Squash",
            "Spanish Cheeses",
            "Spatchcock",
            "Spearmint",
            "Specialty Cheeses",
            "Spinach",
            "Split Peas",
            "Squash",
            "Squid",
            "Star Anise",
            "Steaks",
            "Steam",
            "Stevia",
            "Stilton",
            "Strawberries",
            "Stuffings",
            "Sturgeon",
            "Sucanat",
            "Succotash",
            "Suet",
            "Sugar",
            "Sultana",
            "Sumac",
            "Summer Squash",
            "Sunflower Seeds",
            "Sushi",
            "Sweet Chili Sauce",
            "Sweet Peppers",
            "Sweet Potatoes",
            "Sweetbreads",
            "Sweetened Condensed Milk",
            "Swiss Cheese",
            "Swordfish",
            "Tabasco Sauce",
            "Tagine",
            "Tahini",
            "Tamarillo",
            "Tamarind",
            "Tandoori Paste",
            "Tapioca",
            "Tarragon",
            "Tartar Sauce",
            "Tasso",
            "Tatsoi",
            "Tea",
            "Teff",
            "Tempeh",
            "Terrapins",
            "Thyme",
            "Tofu",
            "Togarashi",
            "Tomatoes",
            "Tomato Juice",
            "Tomato Paste",
            "Tomato Puree",
            "Tomato Sauce",
            "Tonic Water",
            "Tortillas",
            "Trappist Or Monastery-Style Cheese",
            "Tripe",
            "Trompette De La Mort Mushroom",
            "Trout",
            "Truffles",
            "Tuna",
            "Turbinado Sugar",
            "Turkeys",
            "Turmeric",
            "Turnips",
            "Turtles",
            "Udo",
            "Udon Noodles",
            "Ugli Fruit",
            "Umeboshi",
            "Unsweetened Chocolate",
            "Urad Dal",
            "Vanilla",
            "Vanilla Bean",
            "Veal",
            "Vegan Brand Names",
            "Vegemite",
            "Vegetable Marrow",
            "Vegetarian Brand Names",
            "Veloute",
            "Velveeta",
            "Venison",
            "Vermouth",
            "Vidalia Onions",
            "Vincotto",
            "Vinegar",
            "Vital Wheat Gluten",
            "Wakame Seaweed Salad",
            "Walnuts",
            "Wasabi",
            "Washed-Rind Cheese",
            "Water",
            "Water Bath",
            "Water Chestnuts",
            "Waterblommetji",
            "Watercress",
            "Watermelons",
            "Watermelon Radishes",
            "Wattleseed",
            "Weetabix",
            "Weisswurst",
            "Welsh Rarebit",
            "Wensleydale Cheese",
            "Wheat Berries",
            "Wheat Germ",
            "Whelks",
            "White Beans",
            "White Chocolate",
            "Wild Rice",
            "Wine",
            "Wine Vinegar",
            "Won Ton Skins",
            "Woodruff",
            "Worcestershire Sauce",
            "Yabbies",
            "Yeast",
            "Yogurt",
            "Yukon Gold Potatoes",
            "Yuzu Kosho",
            "Za\'atar",
            "Zabaglione",
            "Zest",
            "Zinfandel Wine",
            "Zucchinis",
            "Sauce",
            "Source"});
            this.txtIngredients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIngredients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredients.Location = new System.Drawing.Point(8, 40);
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(85, 24);
            this.txtIngredients.TabIndex = 80;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(169, 16);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(46, 20);
            this.lblUnits.TabIndex = 79;
            this.lblUnits.Text = "Units";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(98, 16);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 78;
            this.lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 77;
            this.lblName.Text = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRecipe);
            this.tabControl1.Controls.Add(this.tabPageIngredients);
            this.tabControl1.Controls.Add(this.tabPageOutput);
            this.tabControl1.Location = new System.Drawing.Point(3, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(279, 309);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageRecipe
            // 
            this.tabPageRecipe.Controls.Add(this.btnRecipeGo);
            this.tabPageRecipe.Controls.Add(this.numericUpDownPeople);
            this.tabPageRecipe.Controls.Add(this.txtName);
            this.tabPageRecipe.Controls.Add(this.lblPeopleNumber);
            this.tabPageRecipe.Controls.Add(this.lblRecipeName);
            this.tabPageRecipe.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecipe.Name = "tabPageRecipe";
            this.tabPageRecipe.Size = new System.Drawing.Size(271, 283);
            this.tabPageRecipe.TabIndex = 0;
            this.tabPageRecipe.Text = "Recipe";
            this.tabPageRecipe.UseVisualStyleBackColor = true;
            // 
            // btnRecipeGo
            // 
            this.btnRecipeGo.Location = new System.Drawing.Point(189, 63);
            this.btnRecipeGo.Name = "btnRecipeGo";
            this.btnRecipeGo.Size = new System.Drawing.Size(75, 23);
            this.btnRecipeGo.TabIndex = 4;
            this.btnRecipeGo.Text = "Go";
            this.btnRecipeGo.UseVisualStyleBackColor = true;
            this.btnRecipeGo.Click += new System.EventHandler(this.btnRecipeGo_Click);
            // 
            // numericUpDownPeople
            // 
            this.numericUpDownPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPeople.Location = new System.Drawing.Point(164, 33);
            this.numericUpDownPeople.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPeople.Name = "numericUpDownPeople";
            this.numericUpDownPeople.Size = new System.Drawing.Size(100, 24);
            this.numericUpDownPeople.TabIndex = 3;
            this.numericUpDownPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(164, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 24);
            this.txtName.TabIndex = 2;
            // 
            // lblPeopleNumber
            // 
            this.lblPeopleNumber.AutoSize = true;
            this.lblPeopleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleNumber.Location = new System.Drawing.Point(5, 33);
            this.lblPeopleNumber.Name = "lblPeopleNumber";
            this.lblPeopleNumber.Size = new System.Drawing.Size(128, 18);
            this.lblPeopleNumber.TabIndex = 1;
            this.lblPeopleNumber.Text = "Number of People";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(5, 4);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(115, 18);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Name of Recipe";
            // 
            // tabPageIngredients
            // 
            this.tabPageIngredients.AutoScroll = true;
            this.tabPageIngredients.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabPageIngredients.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.tabPageIngredients.Controls.Add(this.btnNext);
            this.tabPageIngredients.Controls.Add(this.btnGo);
            this.tabPageIngredients.Controls.Add(this.comboBoxUnits);
            this.tabPageIngredients.Controls.Add(this.numericUpDownAmount);
            this.tabPageIngredients.Controls.Add(this.txtIngredients);
            this.tabPageIngredients.Controls.Add(this.lblUnits);
            this.tabPageIngredients.Controls.Add(this.lblAmount);
            this.tabPageIngredients.Controls.Add(this.lblName);
            this.tabPageIngredients.Location = new System.Drawing.Point(4, 22);
            this.tabPageIngredients.Name = "tabPageIngredients";
            this.tabPageIngredients.Size = new System.Drawing.Size(271, 283);
            this.tabPageIngredients.TabIndex = 1;
            this.tabPageIngredients.Text = "Ingredients";
            this.tabPageIngredients.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(173, 102);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 114;
            this.btnNext.Text = "Go";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.AutoScroll = true;
            this.tabPageOutput.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabPageOutput.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.tabPageOutput.Controls.Add(this.splitContainer1);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Size = new System.Drawing.Size(271, 283);
            this.tabPageOutput.TabIndex = 2;
            this.tabPageOutput.Text = "Output";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnOutGo);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownOutPeople);
            this.splitContainer1.Panel1.Controls.Add(this.lblNumberPeople);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxUnitsOut);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxAmountOut);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxIngredientOut);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(262, 273);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnOutGo
            // 
            this.btnOutGo.Location = new System.Drawing.Point(182, 30);
            this.btnOutGo.Name = "btnOutGo";
            this.btnOutGo.Size = new System.Drawing.Size(75, 23);
            this.btnOutGo.TabIndex = 5;
            this.btnOutGo.Text = "Go";
            this.btnOutGo.UseVisualStyleBackColor = true;
            this.btnOutGo.Click += new System.EventHandler(this.btnOutGo_Click);
            // 
            // numericUpDownOutPeople
            // 
            this.numericUpDownOutPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOutPeople.Location = new System.Drawing.Point(137, 0);
            this.numericUpDownOutPeople.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericUpDownOutPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOutPeople.Name = "numericUpDownOutPeople";
            this.numericUpDownOutPeople.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownOutPeople.TabIndex = 4;
            this.numericUpDownOutPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberPeople
            // 
            this.lblNumberPeople.AutoSize = true;
            this.lblNumberPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPeople.Location = new System.Drawing.Point(3, 0);
            this.lblNumberPeople.Name = "lblNumberPeople";
            this.lblNumberPeople.Size = new System.Drawing.Size(128, 18);
            this.lblNumberPeople.TabIndex = 3;
            this.lblNumberPeople.Text = "Number of People";
            // 
            // richTextBoxUnitsOut
            // 
            this.richTextBoxUnitsOut.Location = new System.Drawing.Point(197, 23);
            this.richTextBoxUnitsOut.Name = "richTextBoxUnitsOut";
            this.richTextBoxUnitsOut.Size = new System.Drawing.Size(60, 192);
            this.richTextBoxUnitsOut.TabIndex = 123;
            this.richTextBoxUnitsOut.Text = "";
            // 
            // richTextBoxAmountOut
            // 
            this.richTextBoxAmountOut.Location = new System.Drawing.Point(119, 23);
            this.richTextBoxAmountOut.Name = "richTextBoxAmountOut";
            this.richTextBoxAmountOut.Size = new System.Drawing.Size(72, 192);
            this.richTextBoxAmountOut.TabIndex = 122;
            this.richTextBoxAmountOut.Text = "";
            // 
            // richTextBoxIngredientOut
            // 
            this.richTextBoxIngredientOut.Location = new System.Drawing.Point(6, 23);
            this.richTextBoxIngredientOut.Name = "richTextBoxIngredientOut";
            this.richTextBoxIngredientOut.Size = new System.Drawing.Size(107, 192);
            this.richTextBoxIngredientOut.TabIndex = 121;
            this.richTextBoxIngredientOut.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 120;
            this.label7.Text = "Units";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 119;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 118;
            this.label5.Text = "Ingredient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, -62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // helpStripMenuItem1
            // 
            this.helpStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.helpStripMenuItem1.Name = "helpStripMenuItem1";
            this.helpStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRecipe.ResumeLayout(false);
            this.tabPageRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).EndInit();
            this.tabPageIngredients.ResumeLayout(false);
            this.tabPageIngredients.PerformLayout();
            this.tabPageOutput.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutPeople)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRecipe;
        private System.Windows.Forms.Button btnRecipeGo;
        private System.Windows.Forms.NumericUpDown numericUpDownPeople;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPeopleNumber;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TabPage tabPageIngredients;
        private System.Windows.Forms.TabPage tabPageOutput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOutGo;
        private System.Windows.Forms.NumericUpDown numericUpDownOutPeople;
        private System.Windows.Forms.Label lblNumberPeople;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox richTextBoxUnitsOut;
        private System.Windows.Forms.RichTextBox richTextBoxAmountOut;
        private System.Windows.Forms.RichTextBox richTextBoxIngredientOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

