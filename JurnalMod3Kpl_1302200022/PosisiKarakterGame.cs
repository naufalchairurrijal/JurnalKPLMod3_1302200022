using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalMod3Kpl_1302200022
{
    public class PosisiKarakterGame
    {
        public enum State 
        {
            Berdiri,
            Jongkok,
            Terbang,
            Tengkurap
        }
        public enum Trigger 
        {
            TombolW,
            TombolS,
            TombolX
        }

        //state saat ini
        public State currentState = State.Berdiri;

        //membuat kelas baru untuk transisi
        public class Transition
        {
            public State prevState, nextState;
            public Trigger trigger;

            public Transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        //array dari kelas Transition untuk mengisi semua kemungkinan state dan trigger
        Transition[] doorStates =
        {
            new Transition(State.Berdiri, State.Jongkok, Trigger.TombolS),
            new Transition(State.Jongkok, State.Berdiri, Trigger.TombolW),
            new Transition(State.Berdiri, State.Terbang, Trigger.TombolW),
            new Transition(State.Terbang, State.Berdiri, Trigger.TombolS),
            new Transition(State.Terbang, State.Jongkok, Trigger.TombolX),
            new Transition(State.Jongkok, State.Tengkurap, Trigger.TombolS),
            new Transition(State.Tengkurap, State.Jongkok, Trigger.TombolW)

        };

        public State GetNextState(State prev, Trigger trigger)
        {
            State currentState = prev;

            for (int i = 0; i < doorStates.Length; i++)
            {
                if (doorStates[i].prevState == prev && doorStates[i].trigger == trigger)
                {
                    currentState = doorStates[i].nextState;
                }
            }

            return currentState;
        }

        //1302200022 % 3 = 0
        public void activeTrigger(Trigger trigger)
        {
            State nextState = GetNextState(currentState, trigger);
            currentState = nextState;

            if (currentState == State.Berdiri)
            {
                Console.WriteLine("berdiri");
            }
            else if (currentState == State.Jongkok)
            {
                Console.WriteLine("jongkok");
            }
            else if (currentState == State.Terbang)
            {
                Console.WriteLine("terbang");
            }
            else if (currentState == State.Tengkurap)
            {
                Console.WriteLine("tengkurap");
            }

        }


    }
}
