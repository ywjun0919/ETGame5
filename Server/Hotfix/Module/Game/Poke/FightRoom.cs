using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHotfix 
{
    public class PokeRoom
    {
        public int roomId;

        public List<PlayerDto> PlayerList;
        private LibraryModel libraryModel = new LibraryModel();
        public List<CardDto> TableCardList { get; set; }

        public void InitPlayerCards()
        {
            for (int i = 0; i < 17; i++)
            {
                CardDto card = libraryModel.Deal();
                PlayerList[0].Add(card);
                PlayerList[1].Add(card);
                PlayerList[2].Add(card);
            }
            for (int i = 0; i < 3; i++)
            {
                CardDto card = libraryModel.Deal();
                TableCardList.Add(card);
            }
        }

    }
}
