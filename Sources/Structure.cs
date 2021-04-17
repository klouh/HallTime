class ItemData
{
	private Guid id;
	private int index;
	private string name;

}

class Exit
{
	private Timestamp time;

	public getTime() {
		return time;
	}
}

class CoefficientMeasurableItem 
{
	enum CoefficientType 
	{
		C0,
		C1,
		C2
	}

	private CoefficientType coefficientType;
}

class Hall 
{
	private double volume;
	private List<Exit> exits;

	Hall(CoefficientMeasurableItem item) {

	}

	public getVolume() {
		return volume;
	}

	public getMinTime() {
		Timestamp min = Timestamp.Max;
		for (Exit exit : exits) {
			if (exit.getTime() < min) {
				min = exit.getTime();
			}
		}
		return min;
	}
}

class FireSection 
{
	private Timestamp max_time;
	private List<Hall> halls;
	private CoefficientMeasurableItem item;

	private int MAX_TIME_VALUE = 10 * 60;
	private int MIN_TIME_VALUE = 6 * 60;

	FireSection(CoefficientMeasurableItem item);

	public getMintime() {
		Hall max_hall = null;
		double max_volume = 0;
		for (Hall hall : halls) {
			if (hall.getVolume() > max_volume) {
				max_hall = hall;
			}
		}

		return (max_hall.getMinTime() > max_time) ? (MAX_TIME_VALUE) : (MIN_TIME_VALUE);
	}
}

class Scene
{
	private List<FireSection> fireSections;
}

