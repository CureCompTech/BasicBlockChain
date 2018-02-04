using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicBlockChain
{
    class Transaction
    {
        public static void Add(string[] Data)
        {
            // Block pertama perlu ada, dan tiada rangkaian block sebelumnya
            // ia akan di Hard coded dalam program

            // periksa kalau BlockChain ada atau tak ada block
            if (Block.Chain.Count == 0)
            {
                // jika blockclain tiada block, cipta satu

                Block.Chain.Add(new Block
                {
                    PreviousHash = "0",
                    Transactions = new string[] { "apa apa data,", "ini block pertama", "Aiman ada RM900" }
                });
            }

            // setelah selesai cipta block pertama, buat blockchain pula untuk di link kan

            Block.Chain.Add(new Block
            {
                PreviousHash = Compute.BlockHash(Block.Chain[Block.Chain.Count - 1]),
                Transactions = Data
            });

            // selesai blockchain tambahan
        }
    }
}
