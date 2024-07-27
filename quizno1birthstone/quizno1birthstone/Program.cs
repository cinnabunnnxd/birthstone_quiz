using System;

namespace quizno1birthstone
{
    class program
    {
        static void Main()
        {
            int month;
            Console.WriteLine("Birthstone Identifier");
            Console.WriteLine("============================");
            Console.WriteLine("Enter your birth month");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your birthstone is Garnet");
                    Console.WriteLine("January | Garnet");
                    Console.WriteLine("Although garnet is commonly associated with the color red, these gemstones can be found in almost any color and are popular choices");
                    Console.WriteLine("for jewelry of all types. That's excellent news if you're in the market for the January birthstone. The garnet family is one of the");
                    Console.WriteLine("most complex in the gem world. It's not a single species but rather consists of several species and varieties.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("Some believe that garnets are a protective stone, shielding the wearer from injury. This made them particularly popular amongst ");
                    Console.WriteLine("warriors and royalty. Occasionally associated with life-giving blood, red-variety garnets are also connected to vitality, love, and light.");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Your birthstone is Amethyst");
                    Console.WriteLine("Febuary | Amethyst");
                    Console.WriteLine("Amethyst is crystalline quartz in colors ranging from pale lilac to deep reddish purple. It has a reletively high harness of 7, which");
                    Console.WriteLine("means it's very scratch resistant. The February birthstone makes a fine gem for any kind of jewelry.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("As the color purple has long been connected with royalty, amethysts were favored by the ruling class. Over time, amethysts have also ");
                    Console.WriteLine("come to be associated with spirituality, mental clarity, and healing.");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your birthstone is Aquamarine");
                    Console.WriteLine("March | Aquamarine");
                    Console.WriteLine("Named after the color of seawater, aquamarine is the blue to blue-green member of the beryl family. Readily available and moderately ");
                    Console.WriteLine("priced, the March birthstone makes an excellent jewelry stone.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("The name \"aquamarine\" comes from the Latin for \"seawater\", and the stones were thought to protect seafarers. Some associate ");
                    Console.WriteLine("aquamarines with marital happiness and superior intellect.");
                    // Reversed slash in order to use double quotes inside Console.WriteLine();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Your birthstone is Diamond ");
                    Console.WriteLine("April | Diamond");
                    Console.WriteLine("Diamond is the most popular ring stone choice in the world. These gems are prized for their classic beauty and clarity, and diamond ");
                    Console.WriteLine("jewelry has become a status symbol.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("Due to their extreme hardness, overall durability, and undeniable beauty, diamonds are associated with strength and eternal love.");
                    Console.WriteLine("It is no wonder that they are commonly used in both engagement and wedding ring designs");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your birthstone is Emerald");
                    Console.WriteLine("May | Emerald");
                    Console.WriteLine("Emerald has been synonymous with the color green since ancient times. A fine emerald is a truly breathtaking sight, and this member ");
                    Console.WriteLine("of the beryl family deserves its placement among the traditional \"Big Four\" gems, along with diamond, ruby, and sapphire.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("Legand has it that wearing emeralds will imbue the wearer with heightened intelligence and allow them to think objectively.");
                    Console.WriteLine("Others use the stone to promote healing. It has even been claimed that emeralds allow the wearer to predict the future");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Your birthstone is Pearl");
                    Console.WriteLine("June | Pearl");
                    Console.WriteLine("Pearls are the only gems found within living creatures, both salt and freshwater mollusks. However, most pearls on the market");
                    Console.WriteLine("today are cultivated or cultured, since they now occur extremely rarely in nature. While pearls require special care, they have ");
                    Console.WriteLine("an enduring appeal for jewelry, particularly as the traditional June birthstone.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("The finest pearls display unblemished surfaces with even coloring. Thus, there is a natural association with qualities like honesty, ");
                    Console.WriteLine("purity, and wisdom. Some cultures associate pearls with the divine, believing that pearls were tears shed from heaven, while others placed");
                    Console.WriteLine("pearls in the graves of their loved ones. Ancient Chinese lore claims that pearls represent wisdom and power and are carried by dragons.");
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your birthstone is Ruby");
                    Console.WriteLine("July | Ruby");
                    Console.WriteLine("One of the most popular traditional jewelry stones, ruby is exceptionally durable. Its colors — always red — can reach vivid levels of saturation. ");
                    Console.WriteLine("Fine-quality rubies are some of the most expensive gemstones, with record prices over $1,000,000 per carat.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("Rubies have long been connected with physicality and strength. Favored by warriors, rubies were thought to be intimately connected with the human body.");
                    Console.WriteLine("They were credited with increasing the strength and stamina of the wearer. Rubies were also thought to calm anger and help the wearer navigate passionate social situations.");
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your birthstone is Peridot ");
                    Console.WriteLine("August | Peridot");
                    Console.WriteLine("The modern August birthstone, peridot has been prized as a jewelry stone since ancient times. Always green in color but with considerable variations,");
                    Console.WriteLine(" a peridot's particular shade depends on its source.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("Peridots have been credited with protecting their wearer during the night. This is due to the fact that the lively appearance of peridot fostered ancient ");
                    Console.WriteLine("associations between the gemstone and the sun. It was thought that keeping the stone close during dark hours repelled nighttime evil spirits.");
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your birthstone is Sapphire");
                    Console.WriteLine("September | Sapphire");
                    Console.WriteLine("Few gems have held our attention over millennia as well as sapphire. Its pure blue colors and excellent durability make it an exceptional gemstone.");
                    Console.WriteLine("However, not all sapphires are blue. The September birthstone comes in many colors.");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("Sapphires are considered a protective gemstone. They may shield the wearer from physical harm as well as bad intentions and envy. It was also thought that ");
                    Console.WriteLine("sapphires had medicinal properties. Blue sapphires are considered a highly spiritual stone worn by priests. Lastly, sapphires are among the few gemstones ");
                    Console.WriteLine("that can exhibit natural asterism in the form of a six-rayed star.");
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your birthstone is Opal");
                    Console.WriteLine("October | Opal");
                    Console.WriteLine("Opals are in a class by themselves. As a species, opal is so unique its patterns have their own descriptive vocabulary. More than any other gem, ");
                    Console.WriteLine("each opal is distinctly individual. Opals are also the most delicate gemstones commonly worn and require special care.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("Perhaps due to their dynamic appearance, opals are associated with light and magic. As such, some credited opals with healing properties, especially for the eyes.");
                    Console.WriteLine("Some believed that opals could even make the wearer invisible. While some cling to negative superstitions about opals, others wear them for good luck.");
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your birthstone is Citrine ");
                    Console.WriteLine("November | Citrine");
                    Console.WriteLine("Citrine is the yellow to red-orange variety of crystalline quartz. Clever marketing and the rise of \"earth tone\" fashions have made this durable and readily ");
                    Console.WriteLine("available gem a popular modern birthstone in recent years.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("A cousin of amethyst, citrine is also part of the quartz family. Citrine is predominantly associated with healing and happiness. Whether you're having a stomach ache, ");
                    Console.WriteLine("suffering from insomnia, or just feeling stressed, citrines are thought to bring relief.");
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your birthstone is Blue Topaz ");
                    Console.WriteLine("December | Blue Topaz");
                    Console.WriteLine("Most blue topazes come out of the earth colorless or pale blue. A two-step heat and radiation laboratory treatment is then used to turn these stones vivid greenish blue. ");
                    Console.WriteLine("Blue topazes are not only beautiful but inexpensive.");
                    Console.WriteLine(" ");
                    Console.WriteLine("SYMBOLISM");
                    Console.WriteLine("Through the ages, topaz has been popularly associated with wealth. This is likely due to its more common yellow color, which led some to believe that topaz had the mystical");
                    Console.WriteLine(" ability to attract gold.");
                    break;

                default:
                    Console.WriteLine("Kindly enter again your birth month, only 1-12 allowed");
                    break;
            }



        }
    }
}