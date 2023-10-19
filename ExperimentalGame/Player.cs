using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalGame
{
    internal class Player
    {

        // Data

        private int score;
        private int hunger;
        private int flapCount;
        private int moveCount;

        // Functions

        //    =====| SETTERS |=====     

        public int SetScore(int newScore) { return score = newScore; }
        public int SetHunger(int newHunger) { return hunger = newHunger; }
        public int SetFlapCount(int newFC) { return flapCount = newFC; }
        public int SetMoveCount(int newMC) { return moveCount = newMC; }


        //    =====| GETTERS |=====

        public int GetScore() { return score; }
        public int GetHunger() { return hunger; }
        public int GetFlapCount() { return flapCount; }
        public int GetMoveCount() { return moveCount; }

        //     =====| OPERATORS |=====

        public void ScoreAdd(int value) { score += value; }
        public void FlapAdd(int value) { flapCount += value; }
        public void MoveAdd(int value) { moveCount += value; }
        public void HungerAdd(int value) { hunger += value; }
        
        public void HungerMinus(int value) { hunger -= value; }

        public void Reset() { score = 0; flapCount = 0; moveCount = 0; hunger = 100; }
    }
}
