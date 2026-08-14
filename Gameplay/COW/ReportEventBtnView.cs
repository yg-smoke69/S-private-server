using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002288")]
public class ReportEventBtnView : MonoBehaviour
{
	[Token(Token = "0x400D830")]
	[FieldOffset(Offset = "0xC")]
	public UIButton BtnGoToTimePoint;

	[Token(Token = "0x400D831")]
	[FieldOffset(Offset = "0x10")]
	public UILabel LabelTime;

	[Token(Token = "0x400D832")]
	[FieldOffset(Offset = "0x14")]
	private float m_TimePoint;

	[Token(Token = "0x400D833")]
	[FieldOffset(Offset = "0x18")]
	private IHAAMHPPLMG m_PlayerID;

	[Token(Token = "0x600BD5F")]
	[Address(RVA = "0x2406038", Offset = "0x2406038", VA = "0x2406038")]
	public ReportEventBtnView()
	{
	}

	[Token(Token = "0x600BD60")]
	[Address(RVA = "0x2406040", Offset = "0x2406040", VA = "0x2406040")]
	public void Init(int timeMs, float timePoint)
	{
	}

	[Token(Token = "0x600BD61")]
	[Address(RVA = "0x24063DC", Offset = "0x24063DC", VA = "0x24063DC")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600BD62")]
	[Address(RVA = "0x240651C", Offset = "0x240651C", VA = "0x240651C")]
	private void OnHoverOver()
	{
	}

	[Token(Token = "0x600BD63")]
	[Address(RVA = "0x240665C", Offset = "0x240665C", VA = "0x240665C")]
	private void OnHoverOut()
	{
	}

	[Token(Token = "0x600BD64")]
	[Address(RVA = "0x240677C", Offset = "0x240677C", VA = "0x240677C")]
	private void _003COnBtnClick_003Em__0()
	{
	}
}
