using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gymme

{
    class StateMachine
    {
        public enum State
        {
            FOREST,
            FOREST_WEST,
            FOREST_EAST,
            FOREST_SOUTH,
            FOREST_NORTH,
            CAVE_MOUNTAIN,
            CAVE_MOUNTAIN_OUTSIDE,
            CAVE_MOUNTAIN_INSIDE,
            LAKE,
            TOWN,
            HOME_VILLAGE
        }
        public enum Input
        {
            NORTH,
            WEST,
            EAST,
            SOUTH
        }
        bool isVillageAvailable = false;
        State currentState;

        public StateMachine()
        {
            currentState = State.FOREST;
            isVillageAvailable = false;
          
        }
        public string Reset()
        {
            string message = "";
            currentState = State.FOREST;
            isVillageAvailable = false;
            message = "";
            return message;
        }
        public State CurrentState
        {
            get { return currentState; }
        }
        public string Transition(Input input)
        {
            string message = "";
            switch (currentState)
            {
                case State.FOREST:
                    switch (input)
                    {
                        case Input.NORTH:
                            currentState = State.FOREST_NORTH;
                            message = "";
                            break;
                        case Input.WEST:
                            currentState = State.FOREST_WEST;
                            message = "";
                            break;
                        case Input.EAST:
                            currentState = State.FOREST_EAST;
                            message = "";
                            break;
                        case Input.SOUTH:
                            currentState = State.FOREST_SOUTH;
                            message = "";
                            break;
                    }
                    break;
                case State.FOREST_WEST:
                    switch (input)
                    {
                        case Input.NORTH:
                            currentState = State.TOWN;
                            message = "";
                            break;
                        case Input.WEST:
                            break;
                        case Input.EAST:
                            break;
                        case Input.SOUTH:
                            currentState = State.LAKE;
                            message = "";
                            break;
                    }
                    break;
                case State.FOREST_EAST:
                    switch (input)
                    {
                        case Input.NORTH:
                            currentState = State.CAVE_MOUNTAIN_OUTSIDE;
                            message = "";
                            break;
                        case Input.WEST:
                            break;
                        case Input.EAST:
                            break;
                        case Input.SOUTH:
                            if (isVillageAvailable)
                            {
                                currentState = State.HOME_VILLAGE;
                            }
                            else
                            {
                                currentState = State.FOREST;
                            }
                            break;
                    }
                    break;
                case State.FOREST_SOUTH:
                    switch (input)
                    {
                        case Input.NORTH:
                            break;
                        case Input.WEST:
                            currentState = State.LAKE;
                            message = "";
                            break;
                        case Input.EAST:
                            if (isVillageAvailable)
                            {
                                currentState = State.HOME_VILLAGE;
                            }
                            else
                            {
                                currentState = State.FOREST;
                            }
                            break;
                        case Input.SOUTH:
                            break;
                    }
                    break;
                case State.FOREST_NORTH:
                    switch (input)
                    {
                        case Input.NORTH:
                            break;
                        case Input.WEST:
                            currentState = State.TOWN;
                            message = "";
                            break;
                        case Input.EAST:
                            currentState = State.CAVE_MOUNTAIN_OUTSIDE;
                            break;
                        case Input.SOUTH:
                            break;
                    }
                    break;
                case State.CAVE_MOUNTAIN_OUTSIDE:
                    switch (input)
                    {
                        case Input.NORTH:
                            break;
                        case Input.WEST:
                            break;
                        case Input.EAST:
                            break;
                        case Input.SOUTH:
                            break;
                    }
                    break;
            }
            return message;
        }
    }
}