using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002033")]
public class UIOnlineMatchEntranceItemController : UIBaseController
{
	[Token(Token = "0x400CA12")]
	[FieldOffset(Offset = "0x28")]
	private UIChampionshipEntranceItemView m_View;

	[Token(Token = "0x400CA13")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_OpenDetailedInfo;

	[Token(Token = "0x400CA14")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 SHOWDETAILENDPOS;

	[Token(Token = "0x400CA15")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 MOVELEFTENDPOS;

	[Token(Token = "0x400CA16")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 MOVERIGHTENDPOS;

	[Token(Token = "0x400CA17")]
	[FieldOffset(Offset = "0x54")]
	public readonly string[] m_DayInWeekKey;

	[Token(Token = "0x400CA18")]
	[FieldOffset(Offset = "0x58")]
	private int m_Index;

	[Token(Token = "0x400CA19")]
	[FieldOffset(Offset = "0x5C")]
	private float m_MoveAnimDuration;

	[Token(Token = "0x17000FD5")]
	public int Index
	{
		[Token(Token = "0x600A375")]
		[Address(RVA = "0x159EE8C", Offset = "0x159EE8C", VA = "0x159EE8C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A376")]
		[Address(RVA = "0x159EEE4", Offset = "0x159EEE4", VA = "0x159EEE4")]
		set
		{
		}
	}

	[Token(Token = "0x600A374")]
	[Address(RVA = "0x159EA30", Offset = "0x159EA30", VA = "0x159EA30")]
	public UIOnlineMatchEntranceItemController()
	{
	}

	[Token(Token = "0x600A377")]
	[Address(RVA = "0x159EF44", Offset = "0x159EF44", VA = "0x159EF44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A378")]
	[Address(RVA = "0x159EFE8", Offset = "0x159EFE8", VA = "0x159EFE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A379")]
	[Address(RVA = "0x159F2B4", Offset = "0x159F2B4", VA = "0x159F2B4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A37A")]
	[Address(RVA = "0x159F3E8", Offset = "0x159F3E8", VA = "0x159F3E8")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600A37B")]
	[Address(RVA = "0x159F5D4", Offset = "0x159F5D4", VA = "0x159F5D4", Slot = "31")]
	protected virtual void OnEntranceAnimFinish()
	{
	}

	[Token(Token = "0x600A37C")]
	[Address(RVA = "0x159F628", Offset = "0x159F628", VA = "0x159F628")]
	public void OpenDetailedInfo()
	{
	}

	[Token(Token = "0x600A37D")]
	[Address(RVA = "0x159FCF4", Offset = "0x159FCF4", VA = "0x159FCF4")]
	public void CloseDetailedInfo()
	{
	}

	[Token(Token = "0x600A37E")]
	[Address(RVA = "0x159F790", Offset = "0x159F790", VA = "0x159F790")]
	public void SwitchDetailedInfo(bool openDetailedInfo)
	{
	}

	[Token(Token = "0x600A37F")]
	[Address(RVA = "0x159FE5C", Offset = "0x159FE5C", VA = "0x159FE5C")]
	private void OnShowDetailAnimFinish()
	{
	}

	[Token(Token = "0x600A380")]
	[Address(RVA = "0x15A02D4", Offset = "0x15A02D4", VA = "0x15A02D4")]
	public void PlayMoveLeftAnim(bool forward)
	{
	}

	[Token(Token = "0x600A381")]
	[Address(RVA = "0x15A03E8", Offset = "0x15A03E8", VA = "0x15A03E8")]
	public void PlayMoveRightAnim(bool forward)
	{
	}

	[Token(Token = "0x600A382")]
	[Address(RVA = "0x15A04CC", Offset = "0x15A04CC", VA = "0x15A04CC", Slot = "32")]
	public virtual long GetEntranceOpenTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A383")]
	[Address(RVA = "0x15A052C", Offset = "0x15A052C", VA = "0x15A052C", Slot = "33")]
	public virtual long GetSeasonStartTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A384")]
	[Address(RVA = "0x15A058C", Offset = "0x15A058C", VA = "0x15A058C", Slot = "34")]
	public virtual int GetPriority()
	{
		return default(int);
	}

	[Token(Token = "0x600A385")]
	[Address(RVA = "0x15A05E4", Offset = "0x15A05E4", VA = "0x15A05E4", Slot = "35")]
	public virtual int GetMatchType()
	{
		return default(int);
	}

	[Token(Token = "0x600A386")]
	[Address(RVA = "0x15A063C", Offset = "0x15A063C", VA = "0x15A063C")]
	public void OnReposition()
	{
	}

	[Token(Token = "0x600A387")]
	[Address(RVA = "0x15A0704", Offset = "0x15A0704", VA = "0x15A0704")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A388")]
	[Address(RVA = "0x15A070C", Offset = "0x15A070C", VA = "0x15A070C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
