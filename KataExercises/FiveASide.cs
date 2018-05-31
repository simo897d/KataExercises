using System;
using System.Collections.Generic;
using System.Linq;

namespace KataExercises {
    public class Player {
        public string Name { get; }
        public int Score { get; }

        private Player() {

        }

        public Player(string name, int score) {
            Name = name;
            Score = score;
        }
    }

    public class FiveASide {


        public static int ChooseSides(Player[] players) {
            //if (players.Length == 0) {
            //    return 0;
            //}
            //List<Player> TeamOne = new List<Player>();
            //List<Player> TeamTwo = new List<Player>();
            //Player temp = null;
            //for (int i = 0; i < players.Length; i++) {
            //    for (int j = 0; j < players.Length - 1; j++) {
            //        if (players[j].Score < players[j + 1].Score) {
            //            temp = players[j + 1];
            //            players[j + 1] = players[j];
            //            players[j] = temp;
            //        }
            //    }
            //}
            //List<Player> Sorting = players.ToList();
            //if (players.Length == 1) {
            //    return players[0].Score;
            //}
            //if (players.Length == 2) {
            //    return players[0].Score - players[1].Score;
            //}
            //if (players.Length % 2 != 0) {
            //    TeamOne.Add(Sorting.First());
            //    Sorting.Remove(Sorting.First());
            //    TeamTwo.Add(Sorting.Last());
            //    Sorting.Remove(Sorting.Last());
            //    TeamTwo.Add(Sorting.Last());
            //    Sorting.Remove(Sorting.Last());
            //}
            //for (int i = 0; i < players.Length / 2 - 1; i++) {
            //if (Sorting.Count % 2 == 0 && Sorting.Count != 0) {
            //         TeamOne.Add(Sorting.First());

            //        Sorting.Remove(Sorting.First());
            //    TeamTwo.Add(Sorting.First());
            //    Sorting.Remove(Sorting.First());

            //    TeamOne.Add(Sorting.Last());
            //    Sorting.Remove(Sorting.Last());
            //    TeamTwo.Add(Sorting.Last());
            //    Sorting.Remove(Sorting.Last());
            //        }

            //}
            ////if(players.Length % 2 != 0) {
            ////    TeamOne.Add(Sorting.First());
            ////    TeamTwo.Add(Sorting.Last());
            ////    Sorting.Remove(Sorting.Last());
            ////    TeamTwo.Add(Sorting.Last());
            ////}

            ////if(Sorting.Count % 2 == 0 && Sorting.Count != 2) {
            ////    TeamOne.Add(Sorting.First());
            ////    Sorting.Remove(Sorting.First());
            ////    TeamTwo.Add(Sorting.First());
            ////    Sorting.Remove(Sorting.First());

            ////    TeamOne.Add(Sorting.Last());
            ////    Sorting.Remove(Sorting.Last());
            ////    TeamTwo.Add(Sorting.Last());
            ////    Sorting.Remove(Sorting.Last());
            ////}
            //return TeamTwo.Sum(x => x.Score) - TeamOne.Sum(x => x.Score);
        }
    }
}
