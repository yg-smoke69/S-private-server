using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004165")]
public class UIRelocateToLabel : MonoBehaviour
{
	[Token(Token = "0x2004166")]
	public enum RelocateUpdate
	{
		[Token(Token = "0x401B70C")]
		AtStart,
		[Token(Token = "0x401B70D")]
		InUpdate
	}

	[Token(Token = "0x2004167")]
	public enum RelocatePosition
	{
		[Token(Token = "0x401B70F")]
		ToLeft,
		[Token(Token = "0x401B710")]
		ToRight
	}

	[Token(Token = "0x401B706")]
	[FieldOffset(Offset = "0xC")]
	private RelocateUpdate UpdateMode;

	[Token(Token = "0x401B707")]
	[FieldOffset(Offset = "0x10")]
	private RelocatePosition LocatePosition;

	[Token(Token = "0x401B708")]
	[FieldOffset(Offset = "0x14")]
	private UILabel toLabel;

	[Token(Token = "0x401B709")]
	[FieldOffset(Offset = "0x18")]
	private UIWidget target;

	[Token(Token = "0x401B70A")]
	[FieldOffset(Offset = "0x1C")]
	private string lastText;

	[Token(Token = "0x601ABA8")]
	[Address(RVA = "0x2243D00", Offset = "0x2243D00", VA = "0x2243D00")]
	public UIRelocateToLabel()
	{
	}

	[Token(Token = "0x601ABA9")]
	[Address(RVA = "0x2243DA8", Offset = "0x2243DA8", VA = "0x2243DA8")]
	private void Start()
	{
	}

	[Token(Token = "0x601ABAA")]
	[Address(RVA = "0x2244188", Offset = "0x2244188", VA = "0x2244188")]
	private void Update()
	{
	}

	[Token(Token = "0x601ABAB")]
	[Address(RVA = "0x2243E24", Offset = "0x2243E24", VA = "0x2243E24")]
	private void UpdatePosition()
	{
	}
}
