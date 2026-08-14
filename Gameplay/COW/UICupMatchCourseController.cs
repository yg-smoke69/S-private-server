using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002066")]
public class UICupMatchCourseController : UIBaseController
{
	[Token(Token = "0x400CB27")]
	[FieldOffset(Offset = "0x28")]
	protected UICupMatchCourseView m_View;

	[Token(Token = "0x400CB28")]
	[FieldOffset(Offset = "0x2C")]
	protected int m_CupMatchKey;

	[Token(Token = "0x400CB29")]
	[FieldOffset(Offset = "0x30")]
	protected UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB2A")]
	[FieldOffset(Offset = "0x34")]
	private List<Transform> m_CourseTrans;

	[Token(Token = "0x400CB2B")]
	[FieldOffset(Offset = "0x38")]
	protected List<CupMatchCourseItem> m_CourseItems;

	[Token(Token = "0x400CB2C")]
	[FieldOffset(Offset = "0x3C")]
	protected List<GameObject> m_LineEffects;

	[Token(Token = "0x400CB2D")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, List<int>> m_RoundColumnIndexDict;

	[Token(Token = "0x600A5EE")]
	[Address(RVA = "0x2747EAC", Offset = "0x2747EAC", VA = "0x2747EAC")]
	public UICupMatchCourseController()
	{
	}

	[Token(Token = "0x600A5EF")]
	[Address(RVA = "0x2749900", Offset = "0x2749900", VA = "0x2749900")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A5F0")]
	[Address(RVA = "0x274825C", Offset = "0x274825C", VA = "0x274825C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A5F1")]
	[Address(RVA = "0x27499A8", Offset = "0x27499A8", VA = "0x27499A8")]
	private void InitDict()
	{
	}

	[Token(Token = "0x600A5F2")]
	[Address(RVA = "0x2749E20", Offset = "0x2749E20", VA = "0x2749E20")]
	private void InitCourseTrans()
	{
	}

	[Token(Token = "0x600A5F3")]
	[Address(RVA = "0x274A2A4", Offset = "0x274A2A4", VA = "0x274A2A4")]
	private void CreateCourseItem()
	{
	}

	[Token(Token = "0x600A5F4")]
	[Address(RVA = "0x2748810", Offset = "0x2748810", VA = "0x2748810", Slot = "31")]
	public virtual void SetData(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A5F5")]
	[Address(RVA = "0x274B6D0", Offset = "0x274B6D0", VA = "0x274B6D0")]
	public void PlayAnim()
	{
	}

	[Token(Token = "0x600A5F6")]
	[Address(RVA = "0x274A724", Offset = "0x274A724", VA = "0x274A724")]
	public void RefreshCourse()
	{
	}

	[Token(Token = "0x600A5F7")]
	[Address(RVA = "0x274BC88", Offset = "0x274BC88", VA = "0x274BC88")]
	private void ShowLineEffect()
	{
	}

	[Token(Token = "0x600A5F8")]
	[Address(RVA = "0x274B8E0", Offset = "0x274B8E0", VA = "0x274B8E0")]
	private void ShowNextCourseInfo()
	{
	}

	[Token(Token = "0x600A5F9")]
	[Address(RVA = "0x2748BF0", Offset = "0x2748BF0", VA = "0x2748BF0")]
	protected bool NeedShowNextCourseInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x600A5FA")]
	[Address(RVA = "0x2748D08", Offset = "0x2748D08", VA = "0x2748D08")]
	protected List<int> GetNextCourseIndexList()
	{
		return null;
	}

	[Token(Token = "0x600A5FB")]
	[Address(RVA = "0x2748B9C", Offset = "0x2748B9C", VA = "0x2748B9C", Slot = "32")]
	protected virtual void OnRefreshCouse()
	{
	}

	[Token(Token = "0x600A5FC")]
	[Address(RVA = "0x274929C", Offset = "0x274929C", VA = "0x274929C")]
	protected bool IsSelfCouseIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600A5FD")]
	[Address(RVA = "0x274B418", Offset = "0x274B418", VA = "0x274B418")]
	private void RefreshCupMatchIcon()
	{
	}

	[Token(Token = "0x600A5FE")]
	[Address(RVA = "0x274B7A8", Offset = "0x274B7A8", VA = "0x274B7A8")]
	private bool IsRoundColumnItem(int round, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600A5FF")]
	[Address(RVA = "0x274BEEC", Offset = "0x274BEEC", VA = "0x274BEEC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
