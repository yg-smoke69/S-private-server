using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B8A")]
public struct TypeInfo
{
	[Token(Token = "0x40061AB")]
	[FieldOffset(Offset = "0x0")]
	private IOGCEGJJHLK m_ValueType;

	[Token(Token = "0x40061AC")]
	[FieldOffset(Offset = "0x4")]
	private string m_EntityType;

	[Token(Token = "0x17000706")]
	public IOGCEGJJHLK ValueType
	{
		[Token(Token = "0x60057A9")]
		[Address(RVA = "0x93DB94", Offset = "0x93DB94", VA = "0x93DB94")]
		get
		{
			return default(IOGCEGJJHLK);
		}
		[Token(Token = "0x60057AA")]
		[Address(RVA = "0x93DB9C", Offset = "0x93DB9C", VA = "0x93DB9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000707")]
	public string EntityType
	{
		[Token(Token = "0x60057AB")]
		[Address(RVA = "0x93DBA4", Offset = "0x93DBA4", VA = "0x93DBA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60057AC")]
		[Address(RVA = "0x93DBAC", Offset = "0x93DBAC", VA = "0x93DBAC")]
		set
		{
		}
	}

	[Token(Token = "0x60057AD")]
	[Address(RVA = "0x2F512EC", Offset = "0x2F512EC", VA = "0x2F512EC")]
	public static bool operator ==(TypeInfo lhs, TypeInfo rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x60057AE")]
	[Address(RVA = "0x2F51430", Offset = "0x2F51430", VA = "0x2F51430")]
	public static bool operator !=(TypeInfo lhs, TypeInfo rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x60057AF")]
	[Address(RVA = "0x93DBB4", Offset = "0x93DBB4", VA = "0x93DBB4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60057B0")]
	[Address(RVA = "0x93DBBC", Offset = "0x93DBBC", VA = "0x93DBBC")]
	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
