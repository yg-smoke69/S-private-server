using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004168")]
public class UIRelocateToLabelSprite : MonoBehaviour
{
	[Token(Token = "0x2004169")]
	public enum RelocateUpdate
	{
		[Token(Token = "0x401B719")]
		AtStart,
		[Token(Token = "0x401B71A")]
		InUpdate
	}

	[Token(Token = "0x401B711")]
	[FieldOffset(Offset = "0xC")]
	private RelocateUpdate UpdateMode;

	[Token(Token = "0x401B712")]
	[FieldOffset(Offset = "0x10")]
	private UILabel toLabel;

	[Token(Token = "0x401B713")]
	[FieldOffset(Offset = "0x14")]
	private string spriteString;

	[Token(Token = "0x401B714")]
	[FieldOffset(Offset = "0x18")]
	private int locateSpriteIndex;

	[Token(Token = "0x401B715")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject visibleObj;

	[Token(Token = "0x401B716")]
	[FieldOffset(Offset = "0x20")]
	private UIWidget target;

	[Token(Token = "0x401B717")]
	[FieldOffset(Offset = "0x24")]
	private string lastText;

	[Token(Token = "0x601ABAC")]
	[Address(RVA = "0x2244230", Offset = "0x2244230", VA = "0x2244230")]
	public UIRelocateToLabelSprite()
	{
	}

	[Token(Token = "0x601ABAD")]
	[Address(RVA = "0x22442E0", Offset = "0x22442E0", VA = "0x22442E0")]
	private void Start()
	{
	}

	[Token(Token = "0x601ABAE")]
	[Address(RVA = "0x2244770", Offset = "0x2244770", VA = "0x2244770")]
	private void Update()
	{
	}

	[Token(Token = "0x601ABAF")]
	[Address(RVA = "0x224435C", Offset = "0x224435C", VA = "0x224435C")]
	private void UpdatePosition()
	{
	}
}
