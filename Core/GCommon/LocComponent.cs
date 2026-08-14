using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EFE")]
public class LocComponent : MonoBehaviour
{
	[Token(Token = "0x2003EFF")]
	public enum Alignment
	{
		[Token(Token = "0x401A96B")]
		Automatic,
		[Token(Token = "0x401A96C")]
		Left,
		[Token(Token = "0x401A96D")]
		Center,
		[Token(Token = "0x401A96E")]
		Right,
		[Token(Token = "0x401A96F")]
		Justified
	}

	[Token(Token = "0x401A961")]
	[FieldOffset(Offset = "0xC")]
	public string StringID;

	[Token(Token = "0x401A962")]
	[FieldOffset(Offset = "0x10")]
	public FontWeight FontWeight;

	[Token(Token = "0x401A963")]
	[FieldOffset(Offset = "0x14")]
	public bool NoArabic;

	[Token(Token = "0x401A964")]
	[FieldOffset(Offset = "0x15")]
	public bool FixArabicInOtherLang;

	[Token(Token = "0x401A965")]
	[FieldOffset(Offset = "0x16")]
	public bool FixArabicNoRegion;

	[Token(Token = "0x401A966")]
	[FieldOffset(Offset = "0x17")]
	public bool UseArabicAlignment;

	[Token(Token = "0x401A967")]
	[FieldOffset(Offset = "0x18")]
	public Alignment ArabicAlignment;

	[Token(Token = "0x401A968")]
	[FieldOffset(Offset = "0x1C")]
	public bool ClearStringIDAfterDoLoc;

	[Token(Token = "0x401A969")]
	[FieldOffset(Offset = "0x20")]
	private UILabel m_UILabel;

	[Token(Token = "0x6019A74")]
	[Address(RVA = "0x32BD6A0", Offset = "0x32BD6A0", VA = "0x32BD6A0")]
	public LocComponent()
	{
	}

	[Token(Token = "0x6019A75")]
	[Address(RVA = "0x32BD6B0", Offset = "0x32BD6B0", VA = "0x32BD6B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019A76")]
	[Address(RVA = "0x32BD6CC", Offset = "0x32BD6CC", VA = "0x32BD6CC")]
	private void FindTarget()
	{
	}

	[Token(Token = "0x6019A77")]
	[Address(RVA = "0x32BD6D0", Offset = "0x32BD6D0", VA = "0x32BD6D0")]
	private void Process()
	{
	}

	[Token(Token = "0x6019A78")]
	[Address(RVA = "0x32BDD78", Offset = "0x32BDD78", VA = "0x32BDD78")]
	public UILabel GetTargetUILabel()
	{
		return null;
	}

	[Token(Token = "0x6019A79")]
	[Address(RVA = "0x32BD6D4", Offset = "0x32BD6D4", VA = "0x32BD6D4")]
	private void FindTargetUILabel()
	{
	}

	[Token(Token = "0x6019A7A")]
	[Address(RVA = "0x32BD8CC", Offset = "0x32BD8CC", VA = "0x32BD8CC")]
	private void ProcessUILabel()
	{
	}
}
