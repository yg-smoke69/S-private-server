using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C3C")]
public struct TTimeRel
{
	[Token(Token = "0x4019A2F")]
	private const ulong S_TO_MS = 1000uL;

	[Token(Token = "0x4019A30")]
	private const float MS_TO_S = 0.001f;

	[Token(Token = "0x4019A31")]
	[FieldOffset(Offset = "0x0")]
	private ulong _time;

	[Token(Token = "0x60180A0")]
	[Address(RVA = "0x93D00C", Offset = "0x93D00C", VA = "0x93D00C")]
	public TTimeRel(float t)
	{
	}

	[Token(Token = "0x60180A1")]
	[Address(RVA = "0x93D040", Offset = "0x93D040", VA = "0x93D040")]
	public TTimeRel(ulong t)
	{
	}

	[Token(Token = "0x60180A2")]
	[Address(RVA = "0x93D050", Offset = "0x93D050", VA = "0x93D050")]
	public TTimeRel(TTimeRel t)
	{
	}

	[Token(Token = "0x60180A3")]
	[Address(RVA = "0x93D060", Offset = "0x93D060", VA = "0x93D060")]
	public ulong ToMilliseconds()
	{
		return default(ulong);
	}

	[Token(Token = "0x60180A4")]
	[Address(RVA = "0x93D068", Offset = "0x93D068", VA = "0x93D068")]
	public float ToSeconds()
	{
		return default(float);
	}

	[Token(Token = "0x60180A5")]
	[Address(RVA = "0x26442D8", Offset = "0x26442D8", VA = "0x26442D8")]
	public static bool operator ==(TTimeRel a, TTimeRel b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180A6")]
	[Address(RVA = "0x26442F0", Offset = "0x26442F0", VA = "0x26442F0")]
	public static bool operator !=(TTimeRel a, TTimeRel b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180A7")]
	[Address(RVA = "0x2644304", Offset = "0x2644304", VA = "0x2644304")]
	public static bool operator >(TTimeRel a, TTimeRel b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180A8")]
	[Address(RVA = "0x264431C", Offset = "0x264431C", VA = "0x264431C")]
	public static bool operator <(TTimeRel a, TTimeRel b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180A9")]
	[Address(RVA = "0x2644334", Offset = "0x2644334", VA = "0x2644334")]
	public static bool operator >=(TTimeRel a, TTimeRel b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180AA")]
	[Address(RVA = "0x264434C", Offset = "0x264434C", VA = "0x264434C")]
	public static bool operator <=(TTimeRel a, TTimeRel b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180AB")]
	[Address(RVA = "0x2644364", Offset = "0x2644364", VA = "0x2644364")]
	public static bool operator ==(TTimeRel a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180AC")]
	[Address(RVA = "0x264437C", Offset = "0x264437C", VA = "0x264437C")]
	public static bool operator !=(TTimeRel a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180AD")]
	[Address(RVA = "0x2644390", Offset = "0x2644390", VA = "0x2644390")]
	public static bool operator >(TTimeRel a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180AE")]
	[Address(RVA = "0x26443A8", Offset = "0x26443A8", VA = "0x26443A8")]
	public static bool operator <(TTimeRel a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180AF")]
	[Address(RVA = "0x26443C0", Offset = "0x26443C0", VA = "0x26443C0")]
	public static bool operator >=(TTimeRel a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B0")]
	[Address(RVA = "0x26443D8", Offset = "0x26443D8", VA = "0x26443D8")]
	public static bool operator <=(TTimeRel a, ulong b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B1")]
	[Address(RVA = "0x26443F0", Offset = "0x26443F0", VA = "0x26443F0")]
	public static bool operator ==(ulong b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B2")]
	[Address(RVA = "0x2644408", Offset = "0x2644408", VA = "0x2644408")]
	public static bool operator !=(ulong b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B3")]
	[Address(RVA = "0x264441C", Offset = "0x264441C", VA = "0x264441C")]
	public static bool operator >(ulong b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B4")]
	[Address(RVA = "0x2644434", Offset = "0x2644434", VA = "0x2644434")]
	public static bool operator <(ulong b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B5")]
	[Address(RVA = "0x264444C", Offset = "0x264444C", VA = "0x264444C")]
	public static bool operator >=(ulong b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B6")]
	[Address(RVA = "0x2644464", Offset = "0x2644464", VA = "0x2644464")]
	public static bool operator <=(ulong b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B7")]
	[Address(RVA = "0x264447C", Offset = "0x264447C", VA = "0x264447C")]
	public static bool operator ==(TTimeRel a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B8")]
	[Address(RVA = "0x26444B8", Offset = "0x26444B8", VA = "0x26444B8")]
	public static bool operator !=(TTimeRel a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180B9")]
	[Address(RVA = "0x26444F4", Offset = "0x26444F4", VA = "0x26444F4")]
	public static bool operator >(TTimeRel a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180BA")]
	[Address(RVA = "0x2644530", Offset = "0x2644530", VA = "0x2644530")]
	public static bool operator <(TTimeRel a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180BB")]
	[Address(RVA = "0x264456C", Offset = "0x264456C", VA = "0x264456C")]
	public static bool operator >=(TTimeRel a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180BC")]
	[Address(RVA = "0x26445A8", Offset = "0x26445A8", VA = "0x26445A8")]
	public static bool operator <=(TTimeRel a, float b)
	{
		return default(bool);
	}

	[Token(Token = "0x60180BD")]
	[Address(RVA = "0x26445E4", Offset = "0x26445E4", VA = "0x26445E4")]
	public static bool operator ==(float b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180BE")]
	[Address(RVA = "0x2644628", Offset = "0x2644628", VA = "0x2644628")]
	public static bool operator !=(float b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180BF")]
	[Address(RVA = "0x264466C", Offset = "0x264466C", VA = "0x264466C")]
	public static bool operator >(float b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180C0")]
	[Address(RVA = "0x26446B0", Offset = "0x26446B0", VA = "0x26446B0")]
	public static bool operator <(float b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180C1")]
	[Address(RVA = "0x26446F4", Offset = "0x26446F4", VA = "0x26446F4")]
	public static bool operator >=(float b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180C2")]
	[Address(RVA = "0x2644738", Offset = "0x2644738", VA = "0x2644738")]
	public static bool operator <=(float b, TTimeRel a)
	{
		return default(bool);
	}

	[Token(Token = "0x60180C3")]
	[Address(RVA = "0x264477C", Offset = "0x264477C", VA = "0x264477C")]
	public static TTimeAbs operator +(TTimeRel a, TTimeAbs b)
	{
		return default(TTimeAbs);
	}

	[Token(Token = "0x60180C4")]
	[Address(RVA = "0x2644790", Offset = "0x2644790", VA = "0x2644790")]
	public static TTimeRel operator +(TTimeRel a, TTimeRel b)
	{
		return default(TTimeRel);
	}

	[Token(Token = "0x60180C5")]
	[Address(RVA = "0x26447A4", Offset = "0x26447A4", VA = "0x26447A4")]
	public static TTimeRel operator -(TTimeRel a, TTimeRel b)
	{
		return default(TTimeRel);
	}

	[Token(Token = "0x60180C6")]
	[Address(RVA = "0x93D094", Offset = "0x93D094", VA = "0x93D094", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60180C7")]
	[Address(RVA = "0x93D09C", Offset = "0x93D09C", VA = "0x93D09C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
