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
            BEACH,
            BEACH_HOUSE,
            BEACH_HOUSE_RUINS,
            DIRT_ROAD,
            FUEL_STATION,
            FUEL_STATION_ON_FIRE
        }
        public enum Input
        {
            NORTH,
            WEST,
            EAST,
            SOUTH
        }
        bool isBeachHouseInRuins = false;
        bool isFuelStationOnFire = false;
        State currentState;

        public StateMachine()
        {
            currentState = State.BEACH;
            isBeachHouseInRuins = false;
            isFuelStationOnFire = false;
        }
        public string Reset()
        {
            string message = "";
            currentState = State.BEACH;
            isBeachHouseInRuins = false;
            isFuelStationOnFire = false;
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
                case State.BEACH:
                    switch (input)
                    {
                        case Input.NORTH:
                            break;
                        case Input.WEST:
                            break;
                        case Input.EAST:
                            message = "";
                            break;
                        case Input.SOUTH:
                            currentState = State.BEACH_HOUSE;
                            message = "";
                            break;
                    }
                    break;
                case State.BEACH_HOUSE:
                    switch (input)
                    {
                        case Input.NORTH:
                            break;
                        case Input.WEST:
                            break;
                        case Input.EAST:
                            if (isBeachHouseInRuins)
                            {
                                currentState = State.BEACH_HOUSE_RUINS;
                            }
                            else
                            {
                                currentState = State.BEACH_HOUSE;
                            }
                            break;
                        case Input.SOUTH:
                            break;
                    }
                    break;
                case State.BEACH_HOUSE_RUINS:
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
                case State.DIRT_ROAD:
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
                case State.FUEL_STATION:
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
                case State.FUEL_STATION_ON_FIRE:
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