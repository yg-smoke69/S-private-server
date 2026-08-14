using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D23")]
public class MatchmakingSussNtf
{
	[Token(Token = "0x400B80F")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cmatch_id_003Ek__BackingField;

	[Token(Token = "0x400B810")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cserver_addr_003Ek__BackingField;

	[Token(Token = "0x400B811")]
	[FieldOffset(Offset = "0x14")]
	private string _003Csecret_003Ek__BackingField;

	[Token(Token = "0x400B812")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cprepare_token_003Ek__BackingField;

	[Token(Token = "0x400B813")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Csleep_ms_003Ek__BackingField;

	[Token(Token = "0x400B814")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cmap_id_003Ek__BackingField;

	[Token(Token = "0x400B815")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B816")]
	[FieldOffset(Offset = "0x28")]
	private uint _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B817")]
	[FieldOffset(Offset = "0x2C")]
	private bool _003Cuse_cache_003Ek__BackingField;

	[Token(Token = "0x400B818")]
	[FieldOffset(Offset = "0x30")]
	private uint _003Clevel_visual_style_003Ek__BackingField;

	[Token(Token = "0x400B819")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Cdifficulty_003Ek__BackingField;

	[Token(Token = "0x400B81A")]
	[FieldOffset(Offset = "0x38")]
	private bool _003Cfirst_login_003Ek__BackingField;

	[Token(Token = "0x400B81B")]
	[FieldOffset(Offset = "0x39")]
	private bool _003Cis_in_special_pool_003Ek__BackingField;

	[Token(Token = "0x400B81C")]
	[FieldOffset(Offset = "0x3C")]
	private byte[] _003Cworkshop_settings_003Ek__BackingField;

	[Token(Token = "0x400B81D")]
	[FieldOffset(Offset = "0x40")]
	private byte[] _003Cobject_attribute_settings_003Ek__BackingField;

	[Token(Token = "0x400B81E")]
	[FieldOffset(Offset = "0x44")]
	private List<MatchPregameInfo> _003Cpregame_infos_003Ek__BackingField;

	[Token(Token = "0x400B81F")]
	[FieldOffset(Offset = "0x48")]
	private string _003Cworkshop_code_003Ek__BackingField;

	[Token(Token = "0x400B820")]
	[FieldOffset(Offset = "0x4C")]
	private string _003Cworkshop_name_003Ek__BackingField;

	[Token(Token = "0x400B821")]
	[FieldOffset(Offset = "0x50")]
	private EMatch.GroupMode _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B822")]
	[FieldOffset(Offset = "0x54")]
	private bool _003Cis_in_emulator_pool_003Ek__BackingField;

	[Token(Token = "0x17000BFC")]
	public ulong match_id
	{
		[Token(Token = "0x6008766")]
		[Address(RVA = "0x435C7AC", Offset = "0x435C7AC", VA = "0x435C7AC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008767")]
		[Address(RVA = "0x435C7B4", Offset = "0x435C7B4", VA = "0x435C7B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000BFD")]
	public string server_addr
	{
		[Token(Token = "0x6008768")]
		[Address(RVA = "0x435C7C4", Offset = "0x435C7C4", VA = "0x435C7C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008769")]
		[Address(RVA = "0x435C77C", Offset = "0x435C77C", VA = "0x435C77C")]
		set
		{
		}
	}

	[Token(Token = "0x17000BFE")]
	public string secret
	{
		[Token(Token = "0x600876A")]
		[Address(RVA = "0x435C7CC", Offset = "0x435C7CC", VA = "0x435C7CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600876B")]
		[Address(RVA = "0x435C784", Offset = "0x435C784", VA = "0x435C784")]
		set
		{
		}
	}

	[Token(Token = "0x17000BFF")]
	public string prepare_token
	{
		[Token(Token = "0x600876C")]
		[Address(RVA = "0x435C7D4", Offset = "0x435C7D4", VA = "0x435C7D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600876D")]
		[Address(RVA = "0x435C78C", Offset = "0x435C78C", VA = "0x435C78C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C00")]
	public uint sleep_ms
	{
		[Token(Token = "0x600876E")]
		[Address(RVA = "0x435C7DC", Offset = "0x435C7DC", VA = "0x435C7DC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600876F")]
		[Address(RVA = "0x435C7E4", Offset = "0x435C7E4", VA = "0x435C7E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000C01")]
	public uint map_id
	{
		[Token(Token = "0x6008770")]
		[Address(RVA = "0x435C7EC", Offset = "0x435C7EC", VA = "0x435C7EC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008771")]
		[Address(RVA = "0x435C7F4", Offset = "0x435C7F4", VA = "0x435C7F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000C02")]
	public uint game_mode
	{
		[Token(Token = "0x6008772")]
		[Address(RVA = "0x435C7FC", Offset = "0x435C7FC", VA = "0x435C7FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008773")]
		[Address(RVA = "0x435C804", Offset = "0x435C804", VA = "0x435C804")]
		set
		{
		}
	}

	[Token(Token = "0x17000C03")]
	public uint match_mode
	{
		[Token(Token = "0x6008774")]
		[Address(RVA = "0x435C80C", Offset = "0x435C80C", VA = "0x435C80C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008775")]
		[Address(RVA = "0x435C814", Offset = "0x435C814", VA = "0x435C814")]
		set
		{
		}
	}

	[Token(Token = "0x17000C04")]
	public bool use_cache
	{
		[Token(Token = "0x6008776")]
		[Address(RVA = "0x435C81C", Offset = "0x435C81C", VA = "0x435C81C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008777")]
		[Address(RVA = "0x435C824", Offset = "0x435C824", VA = "0x435C824")]
		set
		{
		}
	}

	[Token(Token = "0x17000C05")]
	public uint level_visual_style
	{
		[Token(Token = "0x6008778")]
		[Address(RVA = "0x435C82C", Offset = "0x435C82C", VA = "0x435C82C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008779")]
		[Address(RVA = "0x435C834", Offset = "0x435C834", VA = "0x435C834")]
		set
		{
		}
	}

	[Token(Token = "0x17000C06")]
	public uint difficulty
	{
		[Token(Token = "0x600877A")]
		[Address(RVA = "0x435C83C", Offset = "0x435C83C", VA = "0x435C83C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600877B")]
		[Address(RVA = "0x435C844", Offset = "0x435C844", VA = "0x435C844")]
		set
		{
		}
	}

	[Token(Token = "0x17000C07")]
	public bool first_login
	{
		[Token(Token = "0x600877C")]
		[Address(RVA = "0x435C84C", Offset = "0x435C84C", VA = "0x435C84C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600877D")]
		[Address(RVA = "0x435C854", Offset = "0x435C854", VA = "0x435C854")]
		set
		{
		}
	}

	[Token(Token = "0x17000C08")]
	public bool is_in_special_pool
	{
		[Token(Token = "0x600877E")]
		[Address(RVA = "0x435C85C", Offset = "0x435C85C", VA = "0x435C85C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600877F")]
		[Address(RVA = "0x435C864", Offset = "0x435C864", VA = "0x435C864")]
		set
		{
		}
	}

	[Token(Token = "0x17000C09")]
	public byte[] workshop_settings
	{
		[Token(Token = "0x6008780")]
		[Address(RVA = "0x435C86C", Offset = "0x435C86C", VA = "0x435C86C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008781")]
		[Address(RVA = "0x435C874", Offset = "0x435C874", VA = "0x435C874")]
		set
		{
		}
	}

	[Token(Token = "0x17000C0A")]
	public byte[] object_attribute_settings
	{
		[Token(Token = "0x6008782")]
		[Address(RVA = "0x435C87C", Offset = "0x435C87C", VA = "0x435C87C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008783")]
		[Address(RVA = "0x435C884", Offset = "0x435C884", VA = "0x435C884")]
		set
		{
		}
	}

	[Token(Token = "0x17000C0B")]
	public List<MatchPregameInfo> pregame_infos
	{
		[Token(Token = "0x6008784")]
		[Address(RVA = "0x435C88C", Offset = "0x435C88C", VA = "0x435C88C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008785")]
		[Address(RVA = "0x435C794", Offset = "0x435C794", VA = "0x435C794")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C0C")]
	public string workshop_code
	{
		[Token(Token = "0x6008786")]
		[Address(RVA = "0x435C894", Offset = "0x435C894", VA = "0x435C894")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008787")]
		[Address(RVA = "0x435C79C", Offset = "0x435C79C", VA = "0x435C79C")]
		set
		{
		}
	}

	[Token(Token = "0x17000C0D")]
	public string workshop_name
	{
		[Token(Token = "0x6008788")]
		[Address(RVA = "0x435C89C", Offset = "0x435C89C", VA = "0x435C89C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008789")]
		[Address(RVA = "0x435C7A4", Offset = "0x435C7A4", VA = "0x435C7A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000C0E")]
	public EMatch.GroupMode group_mode
	{
		[Token(Token = "0x600878A")]
		[Address(RVA = "0x435C8A4", Offset = "0x435C8A4", VA = "0x435C8A4")]
		get
		{
			return default(EMatch.GroupMode);
		}
		[Token(Token = "0x600878B")]
		[Address(RVA = "0x435C8AC", Offset = "0x435C8AC", VA = "0x435C8AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C0F")]
	public bool is_in_emulator_pool
	{
		[Token(Token = "0x600878C")]
		[Address(RVA = "0x435C8B4", Offset = "0x435C8B4", VA = "0x435C8B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600878D")]
		[Address(RVA = "0x435C8BC", Offset = "0x435C8BC", VA = "0x435C8BC")]
		set
		{
		}
	}

	[Token(Token = "0x6008765")]
	[Address(RVA = "0x435C668", Offset = "0x435C668", VA = "0x435C668")]
	public MatchmakingSussNtf()
	{
	}
}
