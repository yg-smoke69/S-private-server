using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C3B")]
public struct TTimeAbs
{
	[Token(Token = "0x4019A2C")]
	private const ulong S_TO_MS = 1000uL;

	[Token(Token = "0x4019A2D")]
	private const float MS_TO_S = 0.001f;

	[Token(Token = "0x4019A2E")]
	[FieldOffset(Offset = "0x0")]
	private ulong _time;

	[Token(Token = "0x6018079")]
	[Address(RVA = "0x93CF74", Offset = "0x93CF74", VA = "0x93CF74")]
	public TTimeAbs(float t)
	{
	}

	[Token(Token = "0x601807A")]
	[Address(RVA = "0x93CFA8", Offset = "0x93CFA8", VA = "0x93CFA8")]
	public TTimeAbs(ulong t)
	{
	}

	[Token(Token = "0x601807B")]
	[Address(RVA = "0x93CFB8", Offset = "0x93CFB8", VA = "0x93CFB8")]
	public TTimeAbs(TTimeAbs t)
	{
	}

	[Token(Token = "0x601807C")]
	[Address(RVA = "0x93CFC8", Offset = "0x93CFC8", VA = "0x93CFC8")]
	public ulong ToMilliseconds()
	{
		return default(ulong);
	}

	[Token(Token = "0x601807D")]
	[Address(RVA = "0x93CFD0", Offset = "0x93CFD0", VA = "0x93CFD0")]
	public float ToSeconds()
	{
		return default(float);
	}

	[Token(Token = "0x601807E")]
	[Address(RVA = "0x264268C", Offset = "0x264268C", VA = "0x264268C")]
	public static bool operator ==(TTimeAbs a, TTimeAbs b)
	{
		return default(bool);
	}

	[Token(Token = "0x601807F")]
	[Address(RVA = "0x2643C40", Offset = "0x2643C40", VA = "0x2643C40")]
	public static bool operator !=(TTimeAbs a, TTimeAbs b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018080")]
	[Address(RVA = "0x2642674", Offset = "0x2642674", VA = "0x2642674")]
	public static bool operator >(TTimeAbs a, TTimeAbs b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018081")]
	[Address(RVA = "0x2643C54", Offset = "0x2643C54", VA = "0x2643C54")]
	public static bool operator <(TTimeAbs a, TTimeAbs b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018082")]
	[Address(RVA = "0x2642268", Offset = "0x2642268", VA = "0x2642268")]
	public static bool operator >=(TTimeAbs a, TTimeAbs b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018083")]
	[Address(RVA = "0x26423EC", Offset = "0x26423EC", VA = "0x26423EC")]
	public static bool operator <=(TTimeAbs a, TTimeAbs b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018084")]
	[Address(RVA = "0x2643C6C", Offset = "0x2643C6C", VA = "0x2643C6C")]
	public static bool operator ==(TTimeAbs a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018085")]
	[Address(RVA = "0x2643C84", Offset = "0x2643C84", VA = "0x2643C84")]
	public static bool operator !=(TTimeAbs a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018086")]
	[Address(RVA = "0x2643C98", Offset = "0x2643C98", VA = "0x2643C98")]
	public static bool operator >(TTimeAbs a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018087")]
	[Address(RVA = "0x2643CB0", Offset = "0x2643CB0", VA = "0x2643CB0")]
	public static bool operator <(TTimeAbs a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018088")]
	[Address(RVA = "0x2643CC8", Offset = "0x2643CC8", VA = "0x2643CC8")]
	public static bool operator >=(TTimeAbs a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018089")]
	[Address(RVA = "0x2643CE0", Offset = "0x2643CE0", VA = "0x2643CE0")]
	public static bool operator <=(TTimeAbs a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x601808A")]
	[Address(RVA = "0x2643CF8", Offset = "0x2643CF8", VA = "0x2643CF8")]
	public static bool operator ==(ulong b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x601808B")]
	[Address(RVA = "0x2643D10", Offset = "0x2643D10", VA = "0x2643D10")]
	public static bool operator !=(ulong b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x601808C")]
	[Address(RVA = "0x2643D24", Offset = "0x2643D24", VA = "0x2643D24")]
	public static bool operator >(ulong b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x601808D")]
	[Address(RVA = "0x2643D3C", Offset = "0x2643D3C", VA = "0x2643D3C")]
	public static bool operator <(ulong b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x601808E")]
	[Address(RVA = "0x2643D54", Offset = "0x2643D54", VA = "0x2643D54")]
	public static bool operator >=(ulong b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x601808F")]
	[Address(RVA = "0x2643D6C", Offset = "0x2643D6C", VA = "0x2643D6C")]
	public static bool operator <=(ulong b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x6018090")]
	[Address(RVA = "0x2643D84", Offset = "0x2643D84", VA = "0x2643D84")]
	public static bool operator ==(TTimeAbs a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018091")]
	[Address(RVA = "0x2643DC0", Offset = "0x2643DC0", VA = "0x2643DC0")]
	public static bool operator !=(TTimeAbs a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018092")]
	[Address(RVA = "0x2643DFC", Offset = "0x2643DFC", VA = "0x2643DFC")]
	public static bool operator >(TTimeAbs a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018093")]
	[Address(RVA = "0x2643E38", Offset = "0x2643E38", VA = "0x2643E38")]
	public static bool operator <(TTimeAbs a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018094")]
	[Address(RVA = "0x2643E74", Offset = "0x2643E74", VA = "0x2643E74")]
	public static bool operator >=(TTimeAbs a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018095")]
	[Address(RVA = "0x2643EB0", Offset = "0x2643EB0", VA = "0x2643EB0")]
	public static bool operator <=(TTimeAbs a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018096")]
	[Address(RVA = "0x2643EEC", Offset = "0x2643EEC", VA = "0x2643EEC")]
	public static bool operator ==(float b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x6018097")]
	[Address(RVA = "0x2643F30", Offset = "0x2643F30", VA = "0x2643F30")]
	public static bool operator !=(float b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x6018098")]
	[Address(RVA = "0x2643F74", Offset = "0x2643F74", VA = "0x2643F74")]
	public static bool operator >(float b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x6018099")]
	[Address(RVA = "0x2643FB8", Offset = "0x2643FB8", VA = "0x2643FB8")]
	public static bool operator <(float b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x601809A")]
	[Address(RVA = "0x2643FFC", Offset = "0x2643FFC", VA = "0x2643FFC")]
	public static bool operator >=(float b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x601809B")]
	[Address(RVA = "0x2644040", Offset = "0x2644040", VA = "0x2644040")]
	public static bool operator <=(float b, TTimeAbs a)
	{
		return default(bool);
	}

	[Token(Token = "0x601809C")]
	[Address(RVA = "0x26426DC", Offset = "0x26426DC", VA = "0x26426DC")]
	public static TTimeAbs operator +(TTimeAbs a, TTimeRel b)
	{
		return default(TTimeAbs);
	}

	[Token(Token = "0x601809D")]
	[Address(RVA = "0x264408C", Offset = "0x264408C", VA = "0x264408C")]
	public static TTimeRel operator -(TTimeAbs a, TTimeAbs b)
	{
		return default(TTimeRel);
	}

	[Token(Token = "0x601809E")]
	[Address(RVA = "0x93CFFC", Offset = "0x93CFFC", VA = "0x93CFFC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601809F")]
	[Address(RVA = "0x93D004", Offset = "0x93D004", VA = "0x93D004", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
