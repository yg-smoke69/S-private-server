using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034D6")]
public class UIDigitaluniverseBMissionBaseItemView : MonoBehaviour
{
	[Token(Token = "0x4014BE6")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Desc;

	[Token(Token = "0x4014BE7")]
	[FieldOffset(Offset = "0x10")]
	public UITable ItemGrid;

	[Token(Token = "0x4014BE8")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Operation;

	[Token(Token = "0x4014BE9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject AwardClaimed;

	[Token(Token = "0x4014BEA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Unfinished;

	[Token(Token = "0x4014BEB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject AwardNotClaimed;

	[Token(Token = "0x4014BEC")]
	[FieldOffset(Offset = "0x24")]
	public UIButton AwardNotClaimedBtn;

	[Token(Token = "0x4014BED")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ProgressTips;

	[Token(Token = "0x4014BEE")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Mask;

	[Token(Token = "0x4014BEF")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget Bg;

	[Token(Token = "0x4014BF0")]
	[FieldOffset(Offset = "0x34")]
	public GameObject VFX;

	[Token(Token = "0x6016236")]
	[Address(RVA = "0x2F80198", Offset = "0x2F80198", VA = "0x2F80198")]
	public UIDigitaluniverseBMissionBaseItemView()
	{
	}
}
