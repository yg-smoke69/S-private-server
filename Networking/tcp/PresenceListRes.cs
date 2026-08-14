using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D3A")]
public class PresenceListRes
{
	[Token(Token = "0x400B864")]
	[FieldOffset(Offset = "0x8")]
	private List<PresenceInfo> _003Cpresences_003Ek__BackingField;

	[Token(Token = "0x400B865")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Caccount_list_type_003Ek__BackingField;

	[Token(Token = "0x400B866")]
	[FieldOffset(Offset = "0x10")]
	private ulong[] _003Coffline_account_ids_003Ek__BackingField;

	[Token(Token = "0x17000C3E")]
	public List<PresenceInfo> presences
	{
		[Token(Token = "0x60087FA")]
		[Address(RVA = "0x435CFBC", Offset = "0x435CFBC", VA = "0x435CFBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087FB")]
		[Address(RVA = "0x435CFB4", Offset = "0x435CFB4", VA = "0x435CFB4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C3F")]
	public uint account_list_type
	{
		[Token(Token = "0x60087FC")]
		[Address(RVA = "0x435CFC4", Offset = "0x435CFC4", VA = "0x435CFC4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087FD")]
		[Address(RVA = "0x435CFCC", Offset = "0x435CFCC", VA = "0x435CFCC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C40")]
	public ulong[] offline_account_ids
	{
		[Token(Token = "0x60087FE")]
		[Address(RVA = "0x435CFD4", Offset = "0x435CFD4", VA = "0x435CFD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087FF")]
		[Address(RVA = "0x435CFDC", Offset = "0x435CFDC", VA = "0x435CFDC")]
		set
		{
		}
	}

	[Token(Token = "0x60087F9")]
	[Address(RVA = "0x435CF28", Offset = "0x435CF28", VA = "0x435CF28")]
	public PresenceListRes()
	{
	}
}
