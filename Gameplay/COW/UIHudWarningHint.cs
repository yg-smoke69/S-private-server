using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003353")]
internal class UIHudWarningHint : MonoBehaviour
{
	[Token(Token = "0x40138CE")]
	[FieldOffset(Offset = "0xC")]
	public UISprite m_NearArc;

	[Token(Token = "0x40138CF")]
	[FieldOffset(Offset = "0x10")]
	public UISprite m_NearIcon;

	[Token(Token = "0x40138D0")]
	[FieldOffset(Offset = "0x14")]
	public UISprite m_FarArc;

	[Token(Token = "0x40138D1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_FarIcon;

	[Token(Token = "0x40138D2")]
	[FieldOffset(Offset = "0x20")]
	private IHAAMHPPLMG m_TargetPlayer;

	[Token(Token = "0x40138D3")]
	[FieldOffset(Offset = "0x38")]
	private WarningHintData m_hintData;

	[Token(Token = "0x40138D4")]
	[FieldOffset(Offset = "0x3C")]
	private float m_distance;

	[Token(Token = "0x40138D5")]
	[FieldOffset(Offset = "0x40")]
	private float m_ExpireTime;

	[Token(Token = "0x40138D6")]
	[FieldOffset(Offset = "0x44")]
	private bool m_LongLast;

	[Token(Token = "0x40138D7")]
	[FieldOffset(Offset = "0x45")]
	private bool m_PosFixed;

	[Token(Token = "0x170016CE")]
	public bool PosFixed
	{
		[Token(Token = "0x6015D32")]
		[Address(RVA = "0x1A753C8", Offset = "0x1A753C8", VA = "0x1A753C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016CF")]
	public float ExpireTime
	{
		[Token(Token = "0x6015D33")]
		[Address(RVA = "0x1A75420", Offset = "0x1A75420", VA = "0x1A75420")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170016D0")]
	public int Priority
	{
		[Token(Token = "0x6015D34")]
		[Address(RVA = "0x1A75478", Offset = "0x1A75478", VA = "0x1A75478")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170016D1")]
	public IHAAMHPPLMG TargePlayer
	{
		[Token(Token = "0x6015D35")]
		[Address(RVA = "0x1A754E8", Offset = "0x1A754E8", VA = "0x1A754E8")]
		get
		{
			return default(IHAAMHPPLMG);
		}
	}

	[Token(Token = "0x170016D2")]
	public bool LongLast
	{
		[Token(Token = "0x6015D36")]
		[Address(RVA = "0x1A7555C", Offset = "0x1A7555C", VA = "0x1A7555C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6015D31")]
	[Address(RVA = "0x1A75314", Offset = "0x1A75314", VA = "0x1A75314")]
	public UIHudWarningHint()
	{
	}

	[Token(Token = "0x6015D37")]
	[Address(RVA = "0x1A755B4", Offset = "0x1A755B4", VA = "0x1A755B4")]
	public void SetInfo(IHAAMHPPLMG player, WarningHintData hinData, float distance, bool longLast, bool posFixed = false)
	{
	}

	[Token(Token = "0x6015D38")]
	[Address(RVA = "0x1A75CE4", Offset = "0x1A75CE4", VA = "0x1A75CE4")]
	public void ResetExpireTime()
	{
	}

	[Token(Token = "0x6015D39")]
	[Address(RVA = "0x1A75780", Offset = "0x1A75780", VA = "0x1A75780")]
	public void UpdateStatus()
	{
	}
}
