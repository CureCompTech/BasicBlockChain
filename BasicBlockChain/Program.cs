using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicBlockChain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kita perlu buat satu class untuk simpan data dan juga block
            // Block sudah di bina, sekarang bina Hash Function dalam bentuk SHA256

            // sekarang kita ada Block dan Hash, 
            // kene ada Transaction simple untuk tambah block

            // code asas siap di bina, sekarang baru boleh buat transaksi

            Transaction.Add(new string[] { "Aiman beli SSD RM400", "Aiman ada RM500" });
            Transaction.Add(new string[] { "Aiman mining dapat RM10", "Aiman ada RM510" });

            // kita telah buat bebrapa blockcain, sekarang kita nak paparkan dalam windows

            foreach (var item in Block.Chain)
            {
                Console.Write($"Previous Hash: {item.PreviousHash}\nTransaction: {string.Join(", ", item.Transactions)}\n\n");
            }

            // halang console dari tutup sendiri
            Console.ReadKey();

            // jom cuba test
            // kita dah ada 1 contoh...
            // mari ubah, lihat adakah block hash itu berubah

            // blockhash tidak lagi sama untuk block
            // sistem block chain amat susah untuk ditipu :)

            // sekian...
        }
    }
}
