using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E3D")]
public class AkSwitch : AkDragDropTriggerHandler
{
	[Token(Token = "0x401A582")]
	[FieldOffset(Offset = "0x18")]
	public Switch data;

	[Token(Token = "0x401A583")]
	[FieldOffset(Offset = "0x1C")]
	private int valueIdInternal;

	[Token(Token = "0x401A584")]
	[FieldOffset(Offset = "0x20")]
	private int groupIdInternal;

	[Token(Token = "0x401A585")]
	[FieldOffset(Offset = "0x24")]
	private byte[] valueGuidInternal;

	[Token(Token = "0x401A586")]
	[FieldOffset(Offset = "0x28")]
	private byte[] groupGuidInternal;

	[Token(Token = "0x17001BA2")]
	protected override BaseType WwiseType
	{
		[Token(Token = "0x60194DB")]
		[Address(RVA = "0x2EBA730", Offset = "0x2EBA730", VA = "0x2EBA730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA3")]
	public int valueID
	{
		[Token(Token = "0x60194DD")]
		[Address(RVA = "0x2EBA80C", Offset = "0x2EBA80C", VA = "0x2EBA80C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BA4")]
	public int groupID
	{
		[Token(Token = "0x60194DE")]
		[Address(RVA = "0x2EBA824", Offset = "0x2EBA824", VA = "0x2EBA824")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BA5")]
	public byte[] valueGuid
	{
		[Token(Token = "0x60194DF")]
		[Address(RVA = "0x2EBA83C", Offset = "0x2EBA83C", VA = "0x2EBA83C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA6")]
	public byte[] groupGuid
	{
		[Token(Token = "0x60194E0")]
		[Address(RVA = "0x2EBA8D8", Offset = "0x2EBA8D8", VA = "0x2EBA8D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60194DA")]
	[Address(RVA = "0x2EBA6B4", Offset = "0x2EBA6B4", VA = "0x2EBA6B4")]
	public AkSwitch()
	{
	}

	[Token(Token = "0x60194DC")]
	[Address(RVA = "0x2EBA738", Offset = "0x2EBA738", VA = "0x2EBA738", Slot = "4")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}
}
