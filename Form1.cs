using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QuestEditor
{
    public partial class Form1 : Form
    {
        private FileHeader MyFile = new FileHeader();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Go item File|*.itm";
            openFileDialog1.Title = "Select a item File";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                dataGridView3.Rows.Clear();
                dataGridView3.Refresh();
                dataGridView4.Rows.Clear();
                dataGridView4.Refresh();
                dataGridView5.Rows.Clear();
                dataGridView5.Refresh();
                dataGridView6.Rows.Clear();
                dataGridView6.Refresh();
                dataGridView7.Rows.Clear();
                dataGridView7.Refresh();
                dataGridView8.Rows.Clear();
                dataGridView8.Refresh();
                dataGridView9.Rows.Clear();
                dataGridView9.Refresh();
                dataGridView10.Rows.Clear();
                dataGridView10.Refresh();
                dataGridView11.Rows.Clear();
                dataGridView11.Refresh();
                dataGridView12.Rows.Clear();
                dataGridView12.Refresh();
                dataGridView13.Rows.Clear();
                dataGridView13.Refresh();
                dataGridView14.Rows.Clear();
                dataGridView14.Refresh();
                dataGridView15.Rows.Clear();
                dataGridView15.Refresh();
                dataGridView16.Rows.Clear();
                dataGridView16.Refresh();
                dataGridView17.Rows.Clear();
                dataGridView17.Refresh();
                dataGridView18.Rows.Clear();
                dataGridView18.Refresh();
                dataGridView19.Rows.Clear();
                dataGridView19.Refresh();
                dataGridView20.Rows.Clear();
                dataGridView20.Refresh();
                dataGridView21.Rows.Clear();
                dataGridView21.Refresh();
                dataGridView22.Rows.Clear();
                dataGridView22.Refresh();
                dataGridView23.Rows.Clear();
                dataGridView23.Refresh();
                dataGridView24.Rows.Clear();
                dataGridView24.Refresh();
                dataGridView25.Rows.Clear();
                dataGridView25.Refresh();
                using (BinaryReader bin = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    var a1 = bin.ReadBytes(0xC8);

                    //Weapon

                    var a2 = bin.ReadInt32();

                    label1.Text = "Weapon Count: " + a2.ToString();
                    for (int i = 0; i < a2; i++)
                    {
                        int weaponID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e); // Item Name (Byte [])
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray); // item name (Byte [] => String)
                        byte wGender = bin.ReadByte();
                        byte wJob = bin.ReadByte();
                        byte level = bin.ReadByte();
                        int a6 = bin.ReadInt32(); //type
                        var a7 = bin.ReadInt16(); //PAttack?
                        var a8 = bin.ReadInt16(); //MAttack?
                        var a9 = bin.ReadInt16(); //PRange
                        var a10 = bin.ReadInt16();//MRange
                        byte a11 = bin.ReadByte();
                        var a12 = bin.ReadInt16();
                        var a13 = bin.ReadInt16();
                        var a14 = bin.ReadInt16();
                        var a15 = bin.ReadInt16();
                        var a16 = bin.ReadInt16();
                        var a17 = bin.ReadInt16();
                        var a18 = bin.ReadInt16();
                        int a19 = bin.ReadInt32();
                        int a20 = bin.ReadInt32();
                        int a21 = bin.ReadInt32();
                        int a22 = bin.ReadInt32();
                        int a23 = bin.ReadInt32();
                        byte a24 = bin.ReadByte();
                        int a25 = bin.ReadInt32();
                        byte a26 = bin.ReadByte();
                        var a27 = bin.ReadInt16();
                        var a28 = bin.ReadInt16();
                        var a29 = bin.ReadBytes(0x10);
                        var a30 = bin.ReadBytes(0x14);
                        byte a31 = bin.ReadByte();

                        // dataGridView1.Columns.Add("itemID","itemName","Level");
                        dataGridView1.Rows.Add(weaponID, itemNameString, wGender, wGender, level);
                        //Console.WriteLine("{0} {1} {2} {3} {4}",weaponID,itemNameString,a3,a4,level);
                    }


                    //dress
                    int dressCount = bin.ReadInt32();
                    label2.Text = "Dress Count: " + dressCount;
                    for (int i = 0; i < dressCount; i++)
                    {
                        int dressItemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte dGender = bin.ReadByte();//sex
                        byte dJob = bin.ReadByte();//job
                        byte dLevel = bin.ReadByte();//level
                        int a35 = bin.ReadInt32();
                        var a36 = bin.ReadInt16();
                        var a37 = bin.ReadInt16();
                        var a38 = bin.ReadInt16();
                        var a39 = bin.ReadInt16();
                        var a40 = bin.ReadInt16();
                        var a41 = bin.ReadInt16();
                        var a42 = bin.ReadInt16();
                        var a43 = bin.ReadInt16();
                        int a44 = bin.ReadInt32();
                        int a45 = bin.ReadInt32();
                        int a46 = bin.ReadInt32();
                        int a47 = bin.ReadInt32();
                        int a48 = bin.ReadInt32();
                        byte a49 = bin.ReadByte();
                        int a50 = bin.ReadInt32();
                        byte a51 = bin.ReadByte();
                        var a52 = bin.ReadInt16();
                        var a53 = bin.ReadInt16();
                        var a54 = bin.ReadBytes(0x10);
                        var a55 = bin.ReadBytes(0x14);
                        byte a56 = bin.ReadByte();
                        dataGridView2.ColumnCount = 5;
                        dataGridView2.Columns[0].Name = "Item ID";
                        dataGridView2.Columns[1].Name = "Item Name";
                        dataGridView2.Columns[2].Name = "Gender";
                        dataGridView2.Columns[3].Name = "Job";
                        dataGridView2.Columns[4].Name = "Level";



                        dataGridView2.Rows.Add(dressItemID, itemNameString, dGender, dJob, dLevel);

                    }

                    int ClothCount = bin.ReadInt32();
                    for (int i = 0; i < ClothCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a57 = bin.ReadByte();
                        byte a58 = bin.ReadByte();
                        byte a59 = bin.ReadByte();
                        var a60 = bin.ReadInt16();
                        var a61 = bin.ReadInt16();
                        var a62 = bin.ReadInt16();
                        var a63 = bin.ReadInt16();
                        var a64 = bin.ReadInt16();
                        var a65 = bin.ReadInt16();
                        var a66 = bin.ReadInt16();
                        var a67 = bin.ReadInt16();
                        int a68 = bin.ReadInt32();
                        int a69 = bin.ReadInt32();
                        int a70 = bin.ReadInt32();
                        int a71 = bin.ReadInt32();
                        int a72 = bin.ReadInt32();
                        int a73 = bin.ReadInt32();
                        int a74 = bin.ReadInt32();
                        byte a75 = bin.ReadByte();
                        int a76 = bin.ReadInt32();
                        int a77 = bin.ReadInt32();
                        var a78 = bin.ReadInt16();
                        var a79 = bin.ReadInt16();
                        byte a80 = bin.ReadByte();
                        var a81 = bin.ReadBytes(3);
                        var a82 = bin.ReadBytes(0xC);
                        byte a83 = bin.ReadByte();
                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a82);
                        dataGridView3.ColumnCount = 4;
                        dataGridView3.Columns[0].Name = "Item ID";
                        dataGridView3.Columns[1].Name = "Item Name";
                        dataGridView3.Columns[2].Name = "Price";
                        dataGridView3.Columns[3].Name = "Description";

                        dataGridView3.Rows.Add(itemID, itemNameString, a68, itemDescriptionString);
                    }

                    int ringCount = bin.ReadInt32();
                    for (int i = 0; i < ringCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        var a84 = bin.ReadByte();//job
                        var a85 = bin.ReadByte();//level
                        var a86 = bin.ReadInt16();//str
                        var a87 = bin.ReadInt16();//dex
                        var a88 = bin.ReadInt16();//vit
                        var a89 = bin.ReadInt16();//int
                        var a90 = bin.ReadInt16();//magic
                        var a91 = bin.ReadInt16();//avoid
                        var a92 = bin.ReadInt16();//attack
                        var a93 = bin.ReadInt16();//defense
                        var a94 = bin.ReadInt16();//hp
                        var a95 = bin.ReadInt16();//mp
                        int a96 = bin.ReadInt32();//price
                        int a97 = bin.ReadInt32();
                        int a98 = bin.ReadInt32();
                        int a99 = bin.ReadInt32();
                        int a100 = bin.ReadInt32();
                        var a101 = bin.ReadByte();
                        int a102 = bin.ReadInt32();
                        var a103 = bin.ReadInt16();
                        var a104 = bin.ReadInt16();
                        var a105 = bin.ReadByte();
                        var a106 = bin.ReadBytes(0xA);
                        var a107 = bin.ReadBytes(5);
                        var a108 = bin.ReadByte();
                        var a109 = bin.ReadBytes(0x200);
                        dataGridView4.ColumnCount = 16;
                        dataGridView4.Columns[0].Name = "Item ID";
                        dataGridView4.Columns[1].Name = "Item Name";
                        dataGridView4.Columns[2].Name = "Job";
                        dataGridView4.Columns[3].Name = "Level";
                        dataGridView4.Columns[4].Name = "Str";
                        dataGridView4.Columns[5].Name = "Dex";
                        dataGridView4.Columns[6].Name = "Vit";
                        dataGridView4.Columns[7].Name = "Int";
                        dataGridView4.Columns[8].Name = "Magic";
                        dataGridView4.Columns[9].Name = "Avoid";
                        dataGridView4.Columns[10].Name = "Attack";
                        dataGridView4.Columns[11].Name = "Defense";
                        dataGridView4.Columns[12].Name = "HP";
                        dataGridView4.Columns[13].Name = "MP";
                        dataGridView4.Columns[14].Name = "price";
                        dataGridView4.Columns[15].Name = "Description";

                        string itemDescriptionString =
                Encoding.GetEncoding("UTF-16LE").GetString(a109);





                        dataGridView4.Rows.Add(itemID, itemNameString, a84, a85, a86, a87, a88, a89, a90, a91, a92, a93, a94, a95, a96, itemDescriptionString);
                    }

                    int necklaceCount = bin.ReadInt32();
                    for (int i = 0; i < necklaceCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        var a110 = bin.ReadByte();//job
                        var a111 = bin.ReadByte();//level
                        var a112 = bin.ReadInt16(); //defense
                        var a113 = bin.ReadInt16();
                        var a114 = bin.ReadInt16();
                        var a115 = bin.ReadInt16();
                        var a116 = bin.ReadInt16();
                        var a117 = bin.ReadInt16();//mp
                        var a118 = bin.ReadInt16();//hp
                        int a119 = bin.ReadInt32();//price
                        int a120 = bin.ReadInt32();
                        int a121 = bin.ReadInt32();
                        int a122 = bin.ReadInt32();
                        int a123 = bin.ReadInt32();
                        var a124 = bin.ReadByte();
                        int a125 = bin.ReadInt32();
                        var a126 = bin.ReadInt16();
                        var a127 = bin.ReadInt16();
                        var a128 = bin.ReadByte();
                        var a129 = bin.ReadBytes(0xA);
                        var a130 = bin.ReadBytes(5);
                        var a131 = bin.ReadByte();
                        var a132 = bin.ReadBytes(0x200);
                        string itemDescriptionString =
                   Encoding.GetEncoding("UTF-16LE").GetString(a132);
                        dataGridView5.ColumnCount = 9;
                        dataGridView5.Columns[0].Name = "Item ID";
                        dataGridView5.Columns[1].Name = "Item Name";
                        dataGridView5.Columns[2].Name = "Job";
                        dataGridView5.Columns[3].Name = "Level";
                        dataGridView5.Columns[4].Name = "Defense";
                        dataGridView5.Columns[5].Name = "mp";
                        dataGridView5.Columns[6].Name = "hp";
                        dataGridView5.Columns[7].Name = "Price";
                        dataGridView5.Columns[8].Name = "Description";


                        dataGridView5.Rows.Add(itemID, itemNameString, a110, a111, a112, a117, a118, a119, itemDescriptionString);

                    }

                    int capeCount = bin.ReadInt32();
                    for (int i = 0; i < capeCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a133 = bin.ReadByte();
                        byte a134 = bin.ReadByte();
                        short a135 = bin.ReadInt16();//str
                        short a136 = bin.ReadInt16();//dex
                        short a137 = bin.ReadInt16();//vit
                        short a138 = bin.ReadInt16();//int
                        short a139 = bin.ReadInt16();
                        short a140 = bin.ReadInt16();
                        short a141 = bin.ReadInt16();
                        short a142 = bin.ReadInt16();
                        short a143 = bin.ReadInt16();
                        int a144 = bin.ReadInt32();//price
                        int a145 = bin.ReadInt32();
                        int a146 = bin.ReadInt32();
                        int a147 = bin.ReadInt32();
                        int a148 = bin.ReadInt32();
                        byte a149 = bin.ReadByte();
                        int a150 = bin.ReadInt32();
                        int a151 = bin.ReadInt32();
                        short a152 = bin.ReadInt16();
                        short a153 = bin.ReadInt16();
                        byte a154 = bin.ReadByte();
                        var a155 = bin.ReadBytes(3);
                        var a156 = bin.ReadBytes(0xC);
                        byte a157 = bin.ReadByte();
                        dataGridView6.ColumnCount = 8;
                        dataGridView6.Columns[0].Name = "Item ID";
                        dataGridView6.Columns[1].Name = "Item Name";
                        dataGridView6.Columns[2].Name = "Job";
                        dataGridView6.Columns[3].Name = "Str";
                        dataGridView6.Columns[4].Name = "Dex";
                        dataGridView6.Columns[5].Name = "Vit";
                        dataGridView6.Columns[6].Name = "Int";
                        dataGridView6.Columns[7].Name = "Price";


                        dataGridView6.Rows.Add(itemID, itemNameString, a133, a134, a135, a136, a137, a138, a144);



                    }
                    int useCount = bin.ReadInt32();


                    for (int i = 0; i < useCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a158 = bin.ReadByte();
                        int a159 = bin.ReadInt32();//type
                        int a160 = bin.ReadInt32();//recover
                        int a161 = bin.ReadInt32();
                        int a162 = bin.ReadInt32();//price
                        int a163 = bin.ReadInt32();//1
                        int a164 = bin.ReadInt32();//2
                        int a165 = bin.ReadInt32();//3
                        int a166 = bin.ReadInt32();//4
                        byte a167 = bin.ReadByte();
                        int a168 = bin.ReadInt32();
                        short a169 = bin.ReadInt16();
                        short a170 = bin.ReadInt16();
                        var a171 = bin.ReadBytes(0x10);
                        byte a172 = bin.ReadByte();
                        byte a173 = bin.ReadByte();
                        var a174 = bin.ReadBytes(0x200);


                        string itemDescriptionString =
               Encoding.GetEncoding("UTF-16LE").GetString(a174);
                        string b1 =
              Encoding.GetEncoding("UTF-16LE").GetString(a171);
                        dataGridView7.ColumnCount = 7;
                        dataGridView7.Columns[0].Name = "Item ID";
                        dataGridView7.Columns[1].Name = "Item Name";
                        dataGridView7.Columns[2].Name = "Type";
                        dataGridView7.Columns[3].Name = "Reover";
                        dataGridView7.Columns[4].Name = "Price";

                        dataGridView7.Columns[5].Name = "MaxPerSlot";

                        dataGridView7.Columns[6].Name = "Description";





                        dataGridView7.Rows.Add(itemID, itemNameString, a159, a160, a162, a166, itemDescriptionString);
                    }

                    int soulCount = bin.ReadInt32();
                    for (int i = 0; i < soulCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a175 = bin.ReadByte();
                        int a176 = bin.ReadInt32();//max spirit
                        int a177 = bin.ReadInt32(); //  item spirits?
                        int a178 = bin.ReadInt32();//price
                        int a179 = bin.ReadInt32();
                        int a180 = bin.ReadInt32();
                        int a181 = bin.ReadInt32();
                        int a182 = bin.ReadInt32();
                        byte a183 = bin.ReadByte();
                        int a184 = bin.ReadInt32();
                        short a185 = bin.ReadInt16();
                        short a186 = bin.ReadInt16();
                        var a187 = bin.ReadBytes(0x10);
                        byte a188 = bin.ReadByte();
                        var a189 = bin.ReadBytes(0x200);

                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a189);
                        string b1 =
                        Encoding.GetEncoding("UTF-16LE").GetString(a187);
                        dataGridView8.ColumnCount = 6;
                        dataGridView8.Columns[0].Name = "Item ID";
                        dataGridView8.Columns[1].Name = "Item Name";
                        dataGridView8.Columns[2].Name = "Max Spirit";
                        dataGridView8.Columns[3].Name = "Item Spirit";
                        dataGridView8.Columns[4].Name = "Price";
                        dataGridView8.Columns[5].Name = "Description";
                        dataGridView8.Rows.Add(itemID, itemNameString, a176, a177, a178, itemDescriptionString);
                    }

                    int hatCount = bin.ReadInt32();
                    for (int i = 0; i < hatCount; i++)
                    {

                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a190 = bin.ReadByte();//gender
                        short a191 = bin.ReadInt16();
                        short a192 = bin.ReadInt16();
                        short a193 = bin.ReadInt16();
                        short a194 = bin.ReadInt16();
                        short a195 = bin.ReadInt16();
                        short a196 = bin.ReadInt16();
                        short a197 = bin.ReadInt16();
                        int a198 = bin.ReadInt32();//price
                        int a199 = bin.ReadInt32();
                        int a200 = bin.ReadInt32();
                        int a201 = bin.ReadInt32();
                        int a202 = bin.ReadInt32();
                        byte a203 = bin.ReadByte();
                        int a204 = bin.ReadInt32();
                        int a205 = bin.ReadInt32();
                        short a206 = bin.ReadInt16();
                        short a207 = bin.ReadInt16();
                        byte a208 = bin.ReadByte();
                        var a209 = bin.ReadBytes(3);
                        var a210 = bin.ReadBytes(0xC);
                        byte a211 = bin.ReadByte();
                        dataGridView9.ColumnCount = 4;
                        dataGridView9.Columns[0].Name = "Item ID";
                        dataGridView9.Columns[0].Name = "Item Name";
                        dataGridView9.Columns[0].Name = "Gender";
                        dataGridView9.Columns[0].Name = "Price";

                        dataGridView9.Rows.Add(itemID, itemNameString, a190, a198);


                    }
                    int hairCount = bin.ReadInt32();
                    for (int i = 0; i < hairCount; i++)
                    {

                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);

                        byte a212 = bin.ReadByte();//gender
                        int a213 = bin.ReadInt32();//price
                        int a214 = bin.ReadInt32();
                        int a215 = bin.ReadInt32();
                        int a216 = bin.ReadInt32();
                        int a217 = bin.ReadInt32();
                        byte a218 = bin.ReadByte();
                        int a219 = bin.ReadInt32();
                        short a220 = bin.ReadInt16();
                        short a221 = bin.ReadInt16();
                        var a222 = bin.ReadBytes(0x10);
                        byte a223 = bin.ReadByte();




                        dataGridView10.ColumnCount = 3;
                        dataGridView10.Columns[0].Name = "Item ID";
                        dataGridView10.Columns[1].Name = "Item Name";
                        dataGridView10.Columns[2].Name = "Gender";


                        dataGridView10.Rows.Add(itemID, itemNameString, a212);


                    }
                    int eyeCount = bin.ReadInt32();

                    for (int i = 0; i < eyeCount; i++)
                    {

                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);

                        byte a224 = bin.ReadByte();//gender
                        int a225 = bin.ReadInt32();//price
                        int a226 = bin.ReadInt32();
                        int a227 = bin.ReadInt32();
                        int a228 = bin.ReadInt32();
                        int a229 = bin.ReadInt32();
                        byte a230 = bin.ReadByte();
                        int a231 = bin.ReadInt32();
                        short a232 = bin.ReadInt16();
                        short a233 = bin.ReadInt16();
                        var a234 = bin.ReadBytes(0x10);
                        byte a235 = bin.ReadByte();




                        dataGridView11.ColumnCount = 3;
                        dataGridView11.Columns[0].Name = "Item ID";
                        dataGridView11.Columns[1].Name = "Item Name";
                        dataGridView11.Columns[2].Name = "Gender";


                        dataGridView11.Rows.Add(itemID, itemNameString, a224);


                    }
                    int maskCount = bin.ReadInt32();

                    for (int i = 0; i < maskCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);

                        byte a236 = bin.ReadByte();
                        short a237 = bin.ReadInt16();//str
                        short a238 = bin.ReadInt16();//dex
                        short a239 = bin.ReadInt16();//con
                        short a240 = bin.ReadInt16();//int
                        short a241 = bin.ReadInt16();//??
                        short a242 = bin.ReadInt16();//mp
                        short a243 = bin.ReadInt16();//hp

                        int a244 = bin.ReadInt32();
                        int a245 = bin.ReadInt32();
                        int a246 = bin.ReadInt32();
                        int a247 = bin.ReadInt32();
                        int a248 = bin.ReadInt32();
                        byte a249 = bin.ReadByte();
                        int a250 = bin.ReadInt32();
                        int a251 = bin.ReadInt32();
                        short a252 = bin.ReadInt16();
                        short a253 = bin.ReadInt16();
                        var a254 = bin.ReadBytes(0x10);
                        byte a255 = bin.ReadByte();
                        var a256 = bin.ReadBytes(0x200);


                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a256);
                        dataGridView12.ColumnCount = 10;
                        dataGridView12.Columns[0].Name = "Item ID";
                        dataGridView12.Columns[1].Name = "Item Name";
                        dataGridView12.Columns[2].Name = "Gender";
                        dataGridView12.Columns[3].Name = "str";
                        dataGridView12.Columns[4].Name = "dex";
                        dataGridView12.Columns[5].Name = "con";
                        dataGridView12.Columns[6].Name = "int";

                        dataGridView12.Columns[7].Name = "MP";
                        dataGridView12.Columns[8].Name = "HP";
                        dataGridView12.Columns[9].Name = "Description";



                        dataGridView12.Rows.Add(itemID, itemNameString, a236, a237, a238, a239, a240, a242, a243, itemDescriptionString);
                    }

                    int beardCount = bin.ReadInt32();
                    for (int i = 0; i < beardCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);

                        byte a257 = bin.ReadByte();
                        short a258 = bin.ReadInt16();//str
                        short a259 = bin.ReadInt16();//dex
                        short a260 = bin.ReadInt16();//con
                        short a261 = bin.ReadInt16();//int
                        short a262 = bin.ReadInt16();//??
                        short a263 = bin.ReadInt16();//mp
                        short a264 = bin.ReadInt16();//hp

                        int a265 = bin.ReadInt32();
                        int a266 = bin.ReadInt32();
                        int a267 = bin.ReadInt32();
                        int a268 = bin.ReadInt32();
                        int a269 = bin.ReadInt32();
                        byte a270 = bin.ReadByte();
                        int a271 = bin.ReadInt32();
                        int a272 = bin.ReadInt32();
                        short a273 = bin.ReadInt16();
                        short a274 = bin.ReadInt16();
                        var a275 = bin.ReadBytes(0x10);
                        byte a276 = bin.ReadByte();
                        var a277 = bin.ReadBytes(0x200);


                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a277);
                        dataGridView13.ColumnCount = 10;
                        dataGridView13.Columns[0].Name = "Item ID";
                        dataGridView13.Columns[1].Name = "Item Name";
                        dataGridView13.Columns[2].Name = "Gender";
                        dataGridView13.Columns[3].Name = "str";
                        dataGridView13.Columns[4].Name = "dex";
                        dataGridView13.Columns[5].Name = "con";
                        dataGridView13.Columns[6].Name = "int";

                        dataGridView13.Columns[7].Name = "MP";
                        dataGridView13.Columns[8].Name = "HP";
                        dataGridView13.Columns[9].Name = "Description";



                        dataGridView13.Rows.Add(itemID, itemNameString, a257, a258, a259, a260, a261, a263, a264, itemDescriptionString);
                    }
                    int etcCount = bin.ReadInt32();
                    for (int i = 0; i < etcCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a278 = bin.ReadByte();
                        int a279 = bin.ReadInt32();
                        int a280 = bin.ReadInt32();
                        int a282 = bin.ReadInt32();
                        int a283 = bin.ReadInt32();
                        int a284 = bin.ReadInt32();
                        byte a285 = bin.ReadByte();
                        int a286 = bin.ReadInt32();
                        short a287 = bin.ReadInt16();
                        short a288 = bin.ReadInt16();
                        var a289 = bin.ReadBytes(0x10);
                        byte a290 = bin.ReadByte();
                        var a291 = bin.ReadBytes(0x200);

                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a291);
                        dataGridView14.ColumnCount = 4;
                        dataGridView14.Columns[0].Name = "Item ID";
                        dataGridView14.Columns[1].Name = "Item Name";
                        dataGridView14.Columns[2].Name = "Price";

                        dataGridView14.Columns[3].Name = "Description";



                        dataGridView14.Rows.Add(itemID, itemNameString, a279, itemDescriptionString);

                    }

                    int petCount = bin.ReadInt32();

                    for (int i = 0; i < petCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a291 = bin.ReadByte();
                        int a292 = bin.ReadInt32();
                        int a293 = bin.ReadInt32();
                        int a294 = bin.ReadInt32();
                        int a295 = bin.ReadInt32();
                        int a296 = bin.ReadInt32();
                        int a297 = bin.ReadInt32();
                        int a298 = bin.ReadInt32();//
                        int a299 = bin.ReadInt32();
                        byte a300 = bin.ReadByte();
                        int a301 = bin.ReadInt32();
                        short a302 = bin.ReadInt16();
                        short a303 = bin.ReadInt16();
                        var a304 = bin.ReadBytes(0x10);
                        byte a305 = bin.ReadByte();
                        byte a306 = bin.ReadByte();

                        var a307 = bin.ReadBytes(0x200);
                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a307);
                        dataGridView15.ColumnCount = 4;
                        dataGridView15.Columns[0].Name = "Item ID";
                        dataGridView15.Columns[1].Name = "Item Name";
                        dataGridView15.Columns[2].Name = "Level";



                        dataGridView15.Columns[3].Name = "Description";



                        dataGridView15.Rows.Add(itemID, itemNameString, a291, itemDescriptionString);
                    }
                    int scarfCount = bin.ReadInt32();
                    for (int i = 0; i < scarfCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a308 = bin.ReadByte();
                        short a309 = bin.ReadInt16();
                        short a310 = bin.ReadInt16();
                        short a311 = bin.ReadInt16();
                        int a312 = bin.ReadInt32();
                        int a313 = bin.ReadInt32();
                        int a314 = bin.ReadInt32();
                        int a315 = bin.ReadInt32();
                        int a316 = bin.ReadInt32();
                        byte a317 = bin.ReadByte();
                        int a318 = bin.ReadInt32();
                        short a319 = bin.ReadInt16();
                        short a320 = bin.ReadInt16();
                        var a321 = bin.ReadBytes(0x10);
                        byte a322 = bin.ReadByte();
                        var a323 = bin.ReadBytes(0x200);
                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a323);
                        dataGridView16.ColumnCount = 4;
                        dataGridView16.Columns[0].Name = "Item ID";
                        dataGridView16.Columns[1].Name = "Item Name";
                        dataGridView16.Columns[2].Name = "Level";


                        dataGridView16.Columns[3].Name = "Description";
                        dataGridView16.Rows.Add(itemID, itemNameString, a308, itemDescriptionString);


                    }
                    int unknowCount = bin.ReadInt32();
                    for (int i = 0; i < unknowCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a324 = bin.ReadByte();
                        byte a325 = bin.ReadByte();
                        byte a326 = bin.ReadByte();
                        short a327 = bin.ReadInt16();
                        short a328 = bin.ReadInt16();
                        short a329 = bin.ReadInt16();
                        short a330 = bin.ReadInt16();
                        short a331 = bin.ReadInt16();
                        short a332 = bin.ReadInt16();
                        short a333 = bin.ReadInt16();
                        short a334 = bin.ReadInt16();
                        short a335 = bin.ReadInt16();
                        short a336 = bin.ReadInt16();
                        byte a337 = bin.ReadByte();
                        int a338 = bin.ReadInt32();
                        int a339 = bin.ReadInt32();
                        int a340 = bin.ReadInt32();
                        int a341 = bin.ReadInt32();
                        int a342 = bin.ReadInt32();
                        byte a343 = bin.ReadByte();
                        int a344 = bin.ReadInt32();
                        int a345 = bin.ReadInt32();
                        short a346 = bin.ReadInt16();
                        short a347 = bin.ReadInt16();
                        var a348 = bin.ReadBytes(0x10);
                        var a349 = bin.ReadBytes(6);
                        byte a350 = bin.ReadByte();
                        dataGridView17.ColumnCount = 3;

                        dataGridView17.Columns[0].Name = "Item ID";
                        dataGridView17.Columns[1].Name = "Item Name";
                        dataGridView17.Columns[2].Name = "Level";

                        dataGridView17.Rows.Add(itemID, itemNameString, a324);


                    }
                    int jigsawCount = bin.ReadInt32();
                    for (int i = 0; i < jigsawCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        int a351 = bin.ReadInt32();
                        int a352 = bin.ReadInt32();
                        int a353 = bin.ReadInt32();
                        int a354 = bin.ReadInt32();
                        int a355 = bin.ReadInt32();
                        byte a356 = bin.ReadByte();
                        int a357 = bin.ReadInt32();
                        short a358 = bin.ReadInt16();
                        short a359 = bin.ReadInt16();
                        byte a360 = bin.ReadByte();
                        byte a361 = bin.ReadByte();
                        dataGridView18.ColumnCount = 13;

                        dataGridView18.Columns[0].Name = "Item ID";
                        dataGridView18.Columns[1].Name = "Item Name";
                        dataGridView18.Columns[2].Name = "MaxPerSlot";



                        dataGridView18.Rows.Add(itemID, itemNameString, a355);


                    }






                    int earringCount = bin.ReadInt32();

                    for (int i = 0; i < earringCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a362 = bin.ReadByte();
                        short a363 = bin.ReadInt16();//str
                        short a364 = bin.ReadInt16(); //dex
                        short a365 = bin.ReadInt16();//con
                        short a366 = bin.ReadInt16();//int
                        short a367 = bin.ReadInt16();//def
                        short a368 = bin.ReadInt16();//
                        short a369 = bin.ReadInt16();//
                        short a370 = bin.ReadInt16();//
                        short a371 = bin.ReadInt16();//
                        short a372 = bin.ReadInt16();//
                        byte a373 = bin.ReadByte();
                        int a374 = bin.ReadInt32(); //price
                        int a375 = bin.ReadInt32();
                        int a376 = bin.ReadInt32();
                        int a377 = bin.ReadInt32();
                        int a378 = bin.ReadInt32();
                        byte a379 = bin.ReadByte();
                        int a380 = bin.ReadInt32();
                        short a381 = bin.ReadInt16();
                        short a382 = bin.ReadInt16();
                        byte a383 = bin.ReadByte();
                        byte a384 = bin.ReadByte();
                        var a385 = bin.ReadBytes(0x200);


                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a385);

                        dataGridView19.ColumnCount = 10;
                        dataGridView19.Columns[0].Name = "Item ID";
                        dataGridView19.Columns[1].Name = "Item Name";
                        dataGridView19.Columns[2].Name = "Level";
                        dataGridView19.Columns[3].Name = "STR";
                        dataGridView19.Columns[4].Name = "DEX";
                        dataGridView19.Columns[5].Name = "CON";
                        dataGridView19.Columns[6].Name = "INT";
                        dataGridView19.Columns[7].Name = "DEF";


                        dataGridView19.Columns[8].Name = "Price";
                        dataGridView19.Columns[9].Name = "Description";
                        dataGridView19.Rows.Add(itemID, itemNameString, a362, a363, a364, a365, a366, a367, a374, itemDescriptionString);
                    }

                    int soulCard = bin.ReadInt32();
                    for (int i = 0; i < soulCard; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a386 = bin.ReadByte(); //level
                        short a387 = bin.ReadInt16();
                        int a388 = bin.ReadInt32();
                        int a389 = bin.ReadInt32();
                        int a390 = bin.ReadInt32();
                        int a391 = bin.ReadInt32();
                        byte a392 = bin.ReadByte();
                        byte a393 = bin.ReadByte();
                        int a394 = bin.ReadInt32();
                        short a395 = bin.ReadInt16();
                        byte a396 = bin.ReadByte();
                        int a397 = bin.ReadInt32();
                        int a398 = bin.ReadInt32();
                        byte a399 = bin.ReadByte();
                        int a400 = bin.ReadInt32();
                        byte a401 = bin.ReadByte();
                        var a402 = bin.ReadBytes(0x200);

                        string itemDescriptionString =
                        Encoding.GetEncoding("UTF-16LE").GetString(a402);

                        dataGridView20.ColumnCount = 4;
                        dataGridView20.Columns[0].Name = "Item ID";
                        dataGridView20.Columns[1].Name = "Item Name";
                        dataGridView20.Columns[2].Name = "Item Name";

                        dataGridView20.Columns[3].Name = "Description";
                        dataGridView20.Rows.Add(itemID, itemNameString, a397, itemDescriptionString);
                    }
                    int gemCount = bin.ReadInt32();
                    for (int i = 0; i < gemCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a403 = bin.ReadByte(); //level
                        int a404 = bin.ReadInt32();
                        int a405 = bin.ReadInt32();
                        int a406 = bin.ReadInt32();
                        int a407 = bin.ReadInt32();
                        int a408 = bin.ReadInt32();
                        int a409 = bin.ReadInt32();
                        int a410 = bin.ReadInt32();
                        int a411 = bin.ReadInt32();
                        byte a412 = bin.ReadByte();
                        int a413 = bin.ReadInt32();
                        short a414 = bin.ReadInt16();
                        short a415 = bin.ReadInt16();
                        var a416 = bin.ReadBytes(0x10);
                        byte a417 = bin.ReadByte();
                        byte a418 = bin.ReadByte();
                        var a419 = bin.ReadBytes(0x200);
                        string itemDescriptionString =
                      Encoding.GetEncoding("UTF-16LE").GetString(a419);

                        dataGridView21.ColumnCount = 4;
                        dataGridView21.Columns[0].Name = "Item ID";
                        dataGridView21.Columns[1].Name = "Item Name";
                        dataGridView21.Columns[2].Name = "Level";

                        dataGridView21.Columns[3].Name = "Description";
                        dataGridView21.Rows.Add(itemID, itemNameString, a403, itemDescriptionString);
                    }
                    int hairAccessoriesCount = bin.ReadInt32();
                    //    MessageBox.Show("gemCount Count: " + gemCount, "Info");

                    for (int i = 0; i < hairAccessoriesCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a420 = bin.ReadByte(); //level
                        byte a421 = bin.ReadByte();
                        short a422 = bin.ReadInt16();
                        byte a423 = bin.ReadByte();
                        int a424 = bin.ReadInt32();
                        int a425 = bin.ReadInt32();
                        int a426 = bin.ReadInt32();
                        int a427 = bin.ReadInt32();
                        int a428 = bin.ReadInt32();
                        byte a429 = bin.ReadByte();
                        int a430 = bin.ReadInt32();
                        int a431 = bin.ReadInt32();
                        short a432 = bin.ReadInt16();
                        short a433 = bin.ReadInt16();
                        short a434 = bin.ReadInt16();
                        short a435 = bin.ReadInt16();
                        short a436 = bin.ReadInt16();
                        short a437 = bin.ReadInt16();
                        short a438 = bin.ReadInt16();
                        short a439 = bin.ReadInt16();
                        short a440 = bin.ReadInt16();
                        byte a441 = bin.ReadByte();
                        var a442 = bin.ReadBytes(0x200);

                        string itemDescriptionString =
                    Encoding.GetEncoding("UTF-16LE").GetString(a442);

                        dataGridView22.ColumnCount = 4;
                        dataGridView22.Columns[0].Name = "Item ID";
                        dataGridView22.Columns[1].Name = "Item Name";
                        dataGridView22.Columns[2].Name = "Level";

                        dataGridView22.Columns[3].Name = "Description";
                        dataGridView22.Rows.Add(itemID, itemNameString, a420, itemDescriptionString);
                    }
                    int braceletCount = bin.ReadInt32();
                    for (int i = 0; i < braceletCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a443 = bin.ReadByte(); //level
                        short a444 = bin.ReadInt16();//str
                        short a445 = bin.ReadInt16();//dex
                        short a446 = bin.ReadInt16();//con
                        short a447 = bin.ReadInt16();//int
                        short a448 = bin.ReadInt16();//def
                        short a449 = bin.ReadInt16();
                        short a450 = bin.ReadInt16();
                        short a451 = bin.ReadInt16();
                        byte a452 = bin.ReadByte();
                        int a453 = bin.ReadInt32();
                        int a454 = bin.ReadInt32();
                        int a455 = bin.ReadInt32();
                        int a456 = bin.ReadInt32();
                        int a457 = bin.ReadInt32();
                        int a458 = bin.ReadInt32();
                        byte a459 = bin.ReadByte();
                        byte a460 = bin.ReadByte();
                        int a461 = bin.ReadInt32();
                        byte a462 = bin.ReadByte();
                        var a463 = bin.ReadBytes(0x200);

                        string itemDescriptionString =
                  Encoding.GetEncoding("UTF-16LE").GetString(a463);

                        dataGridView23.ColumnCount = 9;
                        dataGridView23.Columns[0].Name = "Item ID";
                        dataGridView23.Columns[1].Name = "Item Name";
                        dataGridView23.Columns[2].Name = "Level";
                        dataGridView23.Columns[3].Name = "STR";
                        dataGridView23.Columns[4].Name = "DEX";
                        dataGridView23.Columns[5].Name = "CON";
                        dataGridView23.Columns[6].Name = "INT";
                        dataGridView23.Columns[7].Name = "DEF";

                        dataGridView23.Columns[8].Name = "Description";
                        dataGridView23.Rows.Add(itemID, itemNameString, a443, a444, a445, a446, a447, a448, itemDescriptionString);
                    }
                    int beltCount = bin.ReadInt32();
                    for (int i = 0; i < beltCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a464 = bin.ReadByte(); //level
                        byte a465 = bin.ReadByte();
                        short a466 = bin.ReadInt16();
                        int a467 = bin.ReadInt32();
                        int a468 = bin.ReadInt32();
                        int a469 = bin.ReadInt32();
                        int a470 = bin.ReadInt32();
                        int a471 = bin.ReadInt32();
                        int a472 = bin.ReadInt32();
                        short a473 = bin.ReadInt16();
                        short a474 = bin.ReadInt16();
                        short a475 = bin.ReadInt16();
                        short a476 = bin.ReadInt16();
                        short a477 = bin.ReadInt16();
                        short a478 = bin.ReadInt16();
                        short a479 = bin.ReadInt16();
                        short a480 = bin.ReadInt16();
                        byte a481 = bin.ReadByte();
                        int a482 = bin.ReadInt32();
                        int a483 = bin.ReadInt32();
                        int a484 = bin.ReadInt32();
                        int a485 = bin.ReadInt32();
                        byte a486 = bin.ReadByte();
                        int a487 = bin.ReadInt32();
                        byte a488 = bin.ReadByte();

                        var a489 = bin.ReadBytes(0x200);

                        string itemDescriptionString =
                    Encoding.GetEncoding("UTF-16LE").GetString(a489);

                        dataGridView24.ColumnCount = 4;
                        dataGridView24.Columns[0].Name = "Item ID";
                        dataGridView24.Columns[1].Name = "Item Name";
                        dataGridView24.Columns[2].Name = "Level";

                        dataGridView24.Columns[3].Name = "Description";
                        dataGridView24.Rows.Add(itemID, itemNameString, a464, itemDescriptionString);
                    }

                    int colorSkinCount = bin.ReadInt32();
                    for (int i = 0; i < colorSkinCount; i++)
                    {
                        int itemID = bin.ReadInt32();
                        byte[] itemNameByteArray = bin.ReadBytes(0x3e);
                        string itemNameString =
                            Encoding.GetEncoding("utf-16le").GetString(itemNameByteArray);
                        byte a490 = bin.ReadByte(); //level
                        int a491 = bin.ReadInt32();
                        int a492 = bin.ReadInt32();
                        int a493 = bin.ReadInt32();
                        int a494 = bin.ReadInt32();
                        int a495 = bin.ReadInt32();
                        byte a496 = bin.ReadByte();
                        int a497 = bin.ReadInt32();
                        short a498 = bin.ReadInt16();
                        short a499 = bin.ReadInt16();
                        var a500 = bin.ReadBytes(0x10);
                        byte a501 = bin.ReadByte();

                        dataGridView25.ColumnCount = 4;
                        dataGridView25.Columns[0].Name = "Item ID";
                        dataGridView25.Columns[1].Name = "Item Name";
                        dataGridView25.Columns[2].Name = "Level";



                        dataGridView25.Rows.Add(itemID, itemNameString, a490);
                    }

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text File|*.txt";
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            // setup for export
            dataGridView7.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView7.SelectAll();
            // hiding row headers to avoid extra \t in exported text
            var rowHeaders = dataGridView7.RowHeadersVisible;
            dataGridView7.RowHeadersVisible = false;

            // ! creating text from grid values
            string content = dataGridView7.GetClipboardContent().GetText();

            // restoring grid state
            dataGridView7.ClearSelection();
            dataGridView7.RowHeadersVisible = rowHeaders;

            System.IO.File.WriteAllText(dialog.FileName, content);
            MessageBox.Show(@" Save your tbl file to .txt successfully.");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
