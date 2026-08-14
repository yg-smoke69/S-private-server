using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002065")]
public class UICupMatchCourseAnimController : UICupMatchCourseController
{
	[Token(Token = "0x400CB26")]
	[FieldOffset(Offset = "0x44")]
	private bool m_SetDataReady;

	[Token(Token = "0x600A5E1")]
	[Address(RVA = "0x2747EA8", Offset = "0x2747EA8", VA = "0x2747EA8")]
	public UICupMatchCourseAnimController()
	{
	}

	[Token(Token = "0x600A5E2")]
	[Address(RVA = "0x2748000", Offset = "0x2748000", VA = "0x2748000")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A5E3")]
	[Address(RVA = "0x27480A8", Offset = "0x27480A8", VA = "0x27480A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A5E4")]
	[Address(RVA = "0x2748558", Offset = "0x2748558", VA = "0x2748558", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A5E5")]
	[Address(RVA = "0x274868C", Offset = "0x274868C", VA = "0x274868C", Slot = "31")]
	public override void SetData(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A5E6")]
	[Address(RVA = "0x2748884", Offset = "0x2748884", VA = "0x2748884")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600A5E7")]
	[Address(RVA = "0x2748968", Offset = "0x2748968", VA = "0x2748968", Slot = "32")]
	protected override void OnRefreshCouse()
	{
	}

	[Token(Token = "0x600A5E8")]
	[Address(RVA = "0x2748F20", Offset = "0x2748F20", VA = "0x2748F20")]
	private void SetNextCourseState(List<int> list, bool show)
	{
	}

	[Token(Token = "0x600A5E9")]
	[Address(RVA = "0x274931C", Offset = "0x274931C", VA = "0x274931C")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600A5EA")]
	[Address(RVA = "0x27498EC", Offset = "0x27498EC", VA = "0x27498EC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A5EB")]
	[Address(RVA = "0x27498F0", Offset = "0x27498F0", VA = "0x27498F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A5EC")]
	[Address(RVA = "0x27498F8", Offset = "0x27498F8", VA = "0x27498F8")]
	public void _003C_003EiFixBaseProxy_SetData(int P0)
	{
	}

	[Token(Token = "0x600A5ED")]
	[Address(RVA = "0x27498FC", Offset = "0x27498FC", VA = "0x27498FC")]
	public void _003C_003EiFixBaseProxy_OnRefreshCouse()
	{
	}
}
