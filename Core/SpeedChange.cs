using Il2CppDummyDll;

[Token(Token = "0x2000473")]
public class SpeedChange
{
	[Token(Token = "0x4003D18")]
	[FieldOffset(Offset = "0x8")]
	private float speed;

	[Token(Token = "0x4003D19")]
	[FieldOffset(Offset = "0xC")]
	private float beginTimeStamp;

	[Token(Token = "0x4003D1A")]
	[FieldOffset(Offset = "0x10")]
	private float time1;

	[Token(Token = "0x4003D1B")]
	[FieldOffset(Offset = "0x14")]
	private float acceleration1;

	[Token(Token = "0x4003D1C")]
	[FieldOffset(Offset = "0x18")]
	private float time2;

	[Token(Token = "0x4003D1D")]
	[FieldOffset(Offset = "0x1C")]
	private float acceleration2;

	[Token(Token = "0x4003D1E")]
	[FieldOffset(Offset = "0x20")]
	private bool effect;

	[Token(Token = "0x170001FA")]
	public float ExtraSpeed
	{
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x21D8478", Offset = "0x21D8478", VA = "0x21D8478")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600165E")]
	[Address(RVA = "0x21D8470", Offset = "0x21D8470", VA = "0x21D8470")]
	public SpeedChange()
	{
	}

	[Token(Token = "0x6001660")]
	[Address(RVA = "0x21D8480", Offset = "0x21D8480", VA = "0x21D8480")]
	public void ChangeSpeed(float _time1, float _acceleration1, float _time2, float _acceleration2)
	{
	}

	[Token(Token = "0x6001661")]
	[Address(RVA = "0x21D858C", Offset = "0x21D858C", VA = "0x21D858C")]
	public void OnUpdate()
	{
	}
}
