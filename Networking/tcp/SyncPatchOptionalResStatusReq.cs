using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CF5")]
public class SyncPatchOptionalResStatusReq
{
	[Token(Token = "0x400B744")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B745")]
	[FieldOffset(Offset = "0x10")]
	private EGroup.PlayerPatchOptionalResStatus _003Cstatus_003Ek__BackingField;

	[Token(Token = "0x17000BAB")]
	public ulong group_id
	{
		[Token(Token = "0x60086A6")]
		[Address(RVA = "0x435F460", Offset = "0x435F460", VA = "0x435F460")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60086A7")]
		[Address(RVA = "0x435F468", Offset = "0x435F468", VA = "0x435F468")]
		set
		{
		}
	}

	[Token(Token = "0x17000BAC")]
	public EGroup.PlayerPatchOptionalResStatus status
	{
		[Token(Token = "0x60086A8")]
		[Address(RVA = "0x435F478", Offset = "0x435F478", VA = "0x435F478")]
		get
		{
			return default(EGroup.PlayerPatchOptionalResStatus);
		}
		[Token(Token = "0x60086A9")]
		[Address(RVA = "0x435F480", Offset = "0x435F480", VA = "0x435F480")]
		set
		{
		}
	}

	[Token(Token = "0x60086A5")]
	[Address(RVA = "0x435F458", Offset = "0x435F458", VA = "0x435F458")]
	public SyncPatchOptionalResStatusReq()
	{
	}
}
