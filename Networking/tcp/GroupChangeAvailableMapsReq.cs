using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CEF")]
public class GroupChangeAvailableMapsReq
{
	[Token(Token = "0x400B73B")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B73C")]
	[FieldOffset(Offset = "0x10")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x17000BA2")]
	public ulong group_id
	{
		[Token(Token = "0x600868E")]
		[Address(RVA = "0x33EA298", Offset = "0x33EA298", VA = "0x33EA298")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600868F")]
		[Address(RVA = "0x33EA2A0", Offset = "0x33EA2A0", VA = "0x33EA2A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BA3")]
	public uint[] available_maps
	{
		[Token(Token = "0x6008690")]
		[Address(RVA = "0x33EA2B0", Offset = "0x33EA2B0", VA = "0x33EA2B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008691")]
		[Address(RVA = "0x33EA2B8", Offset = "0x33EA2B8", VA = "0x33EA2B8")]
		set
		{
		}
	}

	[Token(Token = "0x600868D")]
	[Address(RVA = "0x33EA290", Offset = "0x33EA290", VA = "0x33EA290")]
	public GroupChangeAvailableMapsReq()
	{
	}
}
