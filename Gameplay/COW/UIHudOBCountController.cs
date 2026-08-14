using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027D9")]
public class UIHudOBCountController : UIBaseController
{
	[Token(Token = "0x400F60E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudOBCountView m_View;

	[Token(Token = "0x400F60F")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Count;

	[Token(Token = "0x400F610")]
	[FieldOffset(Offset = "0x30")]
	private int m_LikedInqueueCount;

	[Token(Token = "0x400F611")]
	[FieldOffset(Offset = "0x34")]
	private float playTimeStamp;

	[Token(Token = "0x400F612")]
	[FieldOffset(Offset = "0x38")]
	private float interval;

	[Token(Token = "0x600F6E2")]
	[Address(RVA = "0x1F597CC", Offset = "0x1F597CC", VA = "0x1F597CC")]
	public UIHudOBCountController()
	{
	}

	[Token(Token = "0x600F6E3")]
	[Address(RVA = "0x1F5985C", Offset = "0x1F5985C", VA = "0x1F5985C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F6E4")]
	[Address(RVA = "0x1F59900", Offset = "0x1F59900", VA = "0x1F59900", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F6E5")]
	[Address(RVA = "0x1F59D20", Offset = "0x1F59D20", VA = "0x1F59D20", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F6E6")]
	[Address(RVA = "0x1F59D8C", Offset = "0x1F59D8C", VA = "0x1F59D8C")]
	private void UpdateCount(int count)
	{
	}

	[Token(Token = "0x600F6E7")]
	[Address(RVA = "0x1F59EC8", Offset = "0x1F59EC8", VA = "0x1F59EC8")]
	private void OnOBCountChange(object[] data)
	{
	}

	[Token(Token = "0x600F6E8")]
	[Address(RVA = "0x1F5A0A4", Offset = "0x1F5A0A4", VA = "0x1F5A0A4")]
	private void OnStreamerOBCountChange(object[] data)
	{
	}

	[Token(Token = "0x600F6E9")]
	[Address(RVA = "0x1F5A3B4", Offset = "0x1F5A3B4", VA = "0x1F5A3B4")]
	private void OnOBTargetChange(object[] data)
	{
	}

	[Token(Token = "0x600F6EA")]
	[Address(RVA = "0x1F5A678", Offset = "0x1F5A678", VA = "0x1F5A678")]
	private void OnLikeCountChanged(object[] data)
	{
	}

	[Token(Token = "0x600F6EB")]
	[Address(RVA = "0x1F5A6EC", Offset = "0x1F5A6EC", VA = "0x1F5A6EC")]
	private void ShowLike()
	{
	}

	[Token(Token = "0x600F6EC")]
	[Address(RVA = "0x1F59C30", Offset = "0x1F59C30", VA = "0x1F59C30")]
	private void PlayInitState()
	{
	}

	[Token(Token = "0x600F6ED")]
	[Address(RVA = "0x1F5A8B8", Offset = "0x1F5A8B8", VA = "0x1F5A8B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600F6EE")]
	[Address(RVA = "0x1F5A918", Offset = "0x1F5A918", VA = "0x1F5A918")]
	private void OnPopFinished()
	{
	}

	[Token(Token = "0x600F6EF")]
	[Address(RVA = "0x1F5A97C", Offset = "0x1F5A97C", VA = "0x1F5A97C")]
	private void OnGameStreamerSkillActive(object[] data)
	{
	}

	[Token(Token = "0x600F6F0")]
	[Address(RVA = "0x1F5AAE0", Offset = "0x1F5AAE0", VA = "0x1F5AAE0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F6F1")]
	[Address(RVA = "0x1F5ADA8", Offset = "0x1F5ADA8", VA = "0x1F5ADA8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F6F2")]
	[Address(RVA = "0x1F5ADB0", Offset = "0x1F5ADB0", VA = "0x1F5ADB0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F6F3")]
	[Address(RVA = "0x1F5ADB8", Offset = "0x1F5ADB8", VA = "0x1F5ADB8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
