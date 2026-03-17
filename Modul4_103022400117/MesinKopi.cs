using System;

public class MesinKopi
{
	public enum State { OFF, STANDBY, BREWING, MAINTENANCE}
	public enum Trigger { POWER_ON, POWER_OFF, START_BREW, FINISH_BREW, START_MAINTENANCE, FINISH_MAINTENANCE}
	public State currentState = State.OFF;

	public void MerubahState(Trigger trigger)
	{
		State nextState = currentState;
		if (currentState == State.OFF && trigger == Trigger.POWER_ON)
		{
			nextState = State.STANDBY;
			Console.WriteLine("Mesin Off berubah menjadi Standby");
		}
		else if (currentState == State.STANDBY && trigger == Trigger.START_BREW)
		{
			nextState = State.BREWING;
			Console.WriteLine("Mesin Standby berubah menjadi Brewing");
		}
		else if (currentState == State.BREWING && trigger == Trigger.FINISH_BREW)
		{
			nextState = State.STANDBY;
			Console.WriteLine("Mesin Brewing berubah menjadi Standby");
		}
		else if (currentState == State.STANDBY && trigger == Trigger.START_MAINTENANCE)
		{
			nextState = State.MAINTENANCE;
			Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
		}
		else if (currentState == State.MAINTENANCE && trigger == Trigger.FINISH_MAINTENANCE)
		{
			nextState = State.STANDBY;
			Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
		}
		else if (currentState == State.STANDBY && trigger == Trigger.POWER_OFF)
		{
			nextState = State.OFF;
			Console.WriteLine("Mesin Standby berubah menjadi Off");
		}
		else
		{
			Console.WriteLine("Perubahan state tidak valid");
		}

		currentState = nextState;
	}
}
