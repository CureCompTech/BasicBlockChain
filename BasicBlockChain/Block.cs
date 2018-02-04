using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicBlockChain
{
    [Serializable] // Ini perlu nanti Hashing Function boleh baca class ini
    class Block
    {
        public string PreviousHash;
        public string[] Transactions;

        // basic data dan header sudah ada, kene buat satu array untuk di baca
        public static List<Block> Chain = new List<Block>();
    }
}
