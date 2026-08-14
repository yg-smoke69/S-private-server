using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD9")]
public class GroupAcceptReq
{
	[Token(Token = "0x400B6BF")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B6C0")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cinviter_account_id_003Ek__BackingField;

	[Token(Token = "0x400B6C1")]
	[FieldOffset(Offset = "0x18")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B6C2")]
	[FieldOffset(Offset = "0x1C")]
	private string _003Cgroup_code_003Ek__BackingField;

	[Token(Token = "0x400B6C3")]
	[FieldOffset(Offset = "0x20")]
	private EGroup.InviteChannelType _003Cinvite_channel_type_003Ek__BackingField;

	[Token(Token = "0x400B6C4")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Csystem_platform_003Ek__BackingField;

	[Token(Token = "0x400B6C5")]
	[FieldOffset(Offset = "0x28")]
	private MatchClientInfo _003Cclient_info_003Ek__BackingField;

	[Token(Token = "0x400B6C6")]
	[FieldOffset(Offset = "0x2C")]
	private string _003Csecret_code_003Ek__BackingField;

	[Token(Token = "0x400B6C7")]
	[FieldOffset(Offset = "0x30")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B6C8")]
	[FieldOffset(Offset = "0x34")]
	private bool _003Cauto_accept_003Ek__BackingField;

	[Token(Token = "0x17000B26")]
	public ulong group_id
	{
		[Token(Token = "0x6008580")]
		[Address(RVA = "0x33EA1C8", Offset = "0x33EA1C8", VA = "0x33EA1C8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008581")]
		[Address(RVA = "0x33EA1D0", Offset = "0x33EA1D0", VA = "0x33EA1D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B27")]
	public ulong inviter_account_id
	{
		[Token(Token = "0x6008582")]
		[Address(RVA = "0x33EA1E0", Offset = "0x33EA1E0", VA = "0x33EA1E0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008583")]
		[Address(RVA = "0x33EA1E8", Offset = "0x33EA1E8", VA = "0x33EA1E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B28")]
	public uint[] available_maps
	{
		[Token(Token = "0x6008584")]
		[Address(RVA = "0x33EA1F8", Offset = "0x33EA1F8", VA = "0x33EA1F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008585")]
		[Address(RVA = "0x33EA200", Offset = "0x33EA200", VA = "0x33EA200")]
		set
		{
		}
	}

	[Token(Token = "0x17000B29")]
	public string group_code
	{
		[Token(Token = "0x6008586")]
		[Address(RVA = "0x33EA208", Offset = "0x33EA208", VA = "0x33EA208")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008587")]
		[Address(RVA = "0x33EA1B0", Offset = "0x33EA1B0", VA = "0x33EA1B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B2A")]
	public EGroup.InviteChannelType invite_channel_type
	{
		[Token(Token = "0x6008588")]
		[Address(RVA = "0x33EA210", Offset = "0x33EA210", VA = "0x33EA210")]
		get
		{
			return default(EGroup.InviteChannelType);
		}
		[Token(Token = "0x6008589")]
		[Address(RVA = "0x33EA218", Offset = "0x33EA218", VA = "0x33EA218")]
		set
		{
		}
	}

	[Token(Token = "0x17000B2B")]
	public uint system_platform
	{
		[Token(Token = "0x600858A")]
		[Address(RVA = "0x33EA220", Offset = "0x33EA220", VA = "0x33EA220")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600858B")]
		[Address(RVA = "0x33EA228", Offset = "0x33EA228", VA = "0x33EA228")]
		set
		{
		}
	}

	[Token(Token = "0x17000B2C")]
	public MatchClientInfo client_info
	{
		[Token(Token = "0x600858C")]
		[Address(RVA = "0x33EA230", Offset = "0x33EA230", VA = "0x33EA230")]
		get
		{
			return null;
		}
		[Token(Token = "0x600858D")]
		[Address(RVA = "0x33EA238", Offset = "0x33EA238", VA = "0x33EA238")]
		set
		{
		}
	}

	[Token(Token = "0x17000B2D")]
	public string secret_code
	{
		[Token(Token = "0x600858E")]
		[Address(RVA = "0x33EA240", Offset = "0x33EA240", VA = "0x33EA240")]
		get
		{
			return null;
		}
		[Token(Token = "0x600858F")]
		[Address(RVA = "0x33EA1B8", Offset = "0x33EA1B8", VA = "0x33EA1B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B2E")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x6008590")]
		[Address(RVA = "0x33EA248", Offset = "0x33EA248", VA = "0x33EA248")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008591")]
		[Address(RVA = "0x33EA1C0", Offset = "0x33EA1C0", VA = "0x33EA1C0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000B2F")]
	public bool auto_accept
	{
		[Token(Token = "0x6008592")]
		[Address(RVA = "0x33EA250", Offset = "0x33EA250", VA = "0x33EA250")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008593")]
		[Address(RVA = "0x33EA258", Offset = "0x33EA258", VA = "0x33EA258")]
		set
		{
		}
	}

	[Token(Token = "0x600857F")]
	[Address(RVA = "0x33EA0D0", Offset = "0x33EA0D0", VA = "0x33EA0D0")]
	public GroupAcceptReq()
	{
	}
}
