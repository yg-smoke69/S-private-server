using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E3B")]
public class AkState : AkDragDropTriggerHandler
{
	[Token(Token = "0x401A578")]
	[FieldOffset(Offset = "0x18")]
	public State data;

	[Token(Token = "0x401A579")]
	[FieldOffset(Offset = "0x1C")]
	private int valueIdInternal;

	[Token(Token = "0x401A57A")]
	[FieldOffset(Offset = "0x20")]
	private int groupIdInternal;

	[Token(Token = "0x401A57B")]
	[FieldOffset(Offset = "0x24")]
	private byte[] valueGuidInternal;

	[Token(Token = "0x401A57C")]
	[FieldOffset(Offset = "0x28")]
	private byte[] groupGuidInternal;

	[Token(Token = "0x17001B9D")]
	protected override BaseType WwiseType
	{
		[Token(Token = "0x60194CD")]
		[Address(RVA = "0x2EB8848", Offset = "0x2EB8848", VA = "0x2EB8848", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B9E")]
	public int valueID
	{
		[Token(Token = "0x60194CF")]
		[Address(RVA = "0x2EB887C", Offset = "0x2EB887C", VA = "0x2EB887C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B9F")]
	public int groupID
	{
		[Token(Token = "0x60194D0")]
		[Address(RVA = "0x2EB8894", Offset = "0x2EB8894", VA = "0x2EB8894")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BA0")]
	public byte[] valueGuid
	{
		[Token(Token = "0x60194D1")]
		[Address(RVA = "0x2EB88AC", Offset = "0x2EB88AC", VA = "0x2EB88AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA1")]
	public byte[] groupGuid
	{
		[Token(Token = "0x60194D2")]
		[Address(RVA = "0x2EB8948", Offset = "0x2EB8948", VA = "0x2EB8948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60194CC")]
	[Address(RVA = "0x2EB87CC", Offset = "0x2EB87CC", VA = "0x2EB87CC")]
	public AkState()
	{
	}

	[Token(Token = "0x60194CE")]
	[Address(RVA = "0x2EB8850", Offset = "0x2EB8850", VA = "0x2EB8850", Slot = "4")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}
}
