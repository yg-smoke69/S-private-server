using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CF6")]
public class SyncPatchOptionalResStatusNtf
{
	[Token(Token = "0x400B746")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B747")]
	[FieldOffset(Offset = "0x10")]
	private EGroup.PlayerPatchOptionalResStatus _003Cstatus_003Ek__BackingField;

	[Token(Token = "0x17000BAD")]
	public ulong account_id
	{
		[Token(Token = "0x60086AB")]
		[Address(RVA = "0x435F430", Offset = "0x435F430", VA = "0x435F430")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60086AC")]
		[Address(RVA = "0x435F438", Offset = "0x435F438", VA = "0x435F438")]
		set
		{
		}
	}

	[Token(Token = "0x17000BAE")]
	public EGroup.PlayerPatchOptionalResStatus status
	{
		[Token(Token = "0x60086AD")]
		[Address(RVA = "0x435F448", Offset = "0x435F448", VA = "0x435F448")]
		get
		{
			return default(EGroup.PlayerPatchOptionalResStatus);
		}
		[Token(Token = "0x60086AE")]
		[Address(RVA = "0x435F450", Offset = "0x435F450", VA = "0x435F450")]
		set
		{
		}
	}

	[Token(Token = "0x60086AA")]
	[Address(RVA = "0x435F428", Offset = "0x435F428", VA = "0x435F428")]
	public SyncPatchOptionalResStatusNtf()
	{
	}
}
