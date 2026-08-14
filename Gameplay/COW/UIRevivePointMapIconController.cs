using System.Text;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AD1")]
public class UIRevivePointMapIconController : MonoBehaviour
{
	[Token(Token = "0x4010701")]
	[FieldOffset(Offset = "0xC")]
	private uint m_RevivePointId;

	[Token(Token = "0x4010702")]
	[FieldOffset(Offset = "0x10")]
	private Vector3 m_RevivePointPos;

	[Token(Token = "0x4010703")]
	[FieldOffset(Offset = "0x1C")]
	private HMBBLFKNGGM m_CurrentState;

	[Token(Token = "0x4010704")]
	[FieldOffset(Offset = "0x20")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x4010705")]
	[FieldOffset(Offset = "0x24")]
	private int m_RevivePointMarkShowDis;

	[Token(Token = "0x4010706")]
	[FieldOffset(Offset = "0x28")]
	private bool m_NeedUpdatePosition;

	[Token(Token = "0x4010707")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ProgressBg;

	[Token(Token = "0x4010708")]
	[FieldOffset(Offset = "0x30")]
	public UISprite StateIcon;

	[Token(Token = "0x4010709")]
	[FieldOffset(Offset = "0x34")]
	public UISprite StateBg;

	[Token(Token = "0x401070A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PointStatusLabel;

	[Token(Token = "0x401070B")]
	[FieldOffset(Offset = "0x3C")]
	private StringBuilder m_DistanceStr;

	[Token(Token = "0x401070C")]
	[FieldOffset(Offset = "0x40")]
	private int m_PrevDistance;

	[Token(Token = "0x401070D")]
	[FieldOffset(Offset = "0x0")]
	public static Color ReviveIconNormal;

	[Token(Token = "0x401070E")]
	[FieldOffset(Offset = "0x10")]
	public static Color ReviveBgNormal;

	[Token(Token = "0x401070F")]
	[FieldOffset(Offset = "0x20")]
	public static Color ReviveIconCD;

	[Token(Token = "0x4010710")]
	[FieldOffset(Offset = "0x30")]
	public static Color ReviveBgCD;

	[Token(Token = "0x60118BE")]
	[Address(RVA = "0x1E5715C", Offset = "0x1E5715C", VA = "0x1E5715C")]
	public UIRevivePointMapIconController()
	{
	}

	[Token(Token = "0x60118BF")]
	[Address(RVA = "0x1E57208", Offset = "0x1E57208", VA = "0x1E57208")]
	private void Awake()
	{
	}

	[Token(Token = "0x60118C0")]
	[Address(RVA = "0x1E57358", Offset = "0x1E57358", VA = "0x1E57358")]
	public void SetState(HMBBLFKNGGM state)
	{
	}

	[Token(Token = "0x60118C1")]
	[Address(RVA = "0x1E57924", Offset = "0x1E57924", VA = "0x1E57924")]
	public void SetTime(int time)
	{
	}

	[Token(Token = "0x60118C2")]
	[Address(RVA = "0x1E579CC", Offset = "0x1E579CC", VA = "0x1E579CC")]
	public void SetRevivePointPos(Vector3 v)
	{
	}
}
