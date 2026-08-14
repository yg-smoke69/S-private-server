using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200239C")]
public class MusicMiniGamePhaseOneGameData
{
	[Token(Token = "0x400DDD8")]
	[FieldOffset(Offset = "0x8")]
	private float currentTime;

	[Token(Token = "0x600C812")]
	[Address(RVA = "0x22914E4", Offset = "0x22914E4", VA = "0x22914E4")]
	public MusicMiniGamePhaseOneGameData()
	{
	}

	[Token(Token = "0x600C813")]
	[Address(RVA = "0x22914EC", Offset = "0x22914EC", VA = "0x22914EC")]
	public float GetCurrentTime()
	{
		return default(float);
	}

	[Token(Token = "0x600C814")]
	[Address(RVA = "0x2291544", Offset = "0x2291544", VA = "0x2291544")]
	public void CurrentTimeChange(float delta)
	{
	}

	[Token(Token = "0x600C815")]
	[Address(RVA = "0x22915B4", Offset = "0x22915B4", VA = "0x22915B4")]
	public void InitCurrentTime()
	{
	}
}
