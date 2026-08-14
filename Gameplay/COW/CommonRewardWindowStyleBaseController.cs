using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002034")]
public class CommonRewardWindowStyleBaseController : UIBaseController
{
	[Token(Token = "0x400CA1A")]
	[FieldOffset(Offset = "0x28")]
	public CommonRewardWnd_BGStyle_CommonView m_View;

	[Token(Token = "0x400CA1B")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 TopPos;

	[Token(Token = "0x400CA1C")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 BottomPos;

	[Token(Token = "0x600A389")]
	[Address(RVA = "0x1739A6C", Offset = "0x1739A6C", VA = "0x1739A6C")]
	public CommonRewardWindowStyleBaseController()
	{
	}

	[Token(Token = "0x600A38A")]
	[Address(RVA = "0x1739AF0", Offset = "0x1739AF0", VA = "0x1739AF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A38B")]
	[Address(RVA = "0x1739B94", Offset = "0x1739B94", VA = "0x1739B94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A38C")]
	[Address(RVA = "0x1739E34", Offset = "0x1739E34", VA = "0x1739E34")]
	public Vector3 GetTopPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600A38D")]
	[Address(RVA = "0x1739EA4", Offset = "0x1739EA4", VA = "0x1739EA4")]
	public Vector3 GetBottomPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600A38E")]
	[Address(RVA = "0x1739F14", Offset = "0x1739F14", VA = "0x1739F14", Slot = "31")]
	protected virtual string GetGuideBtnSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600A38F")]
	[Address(RVA = "0x1739FB8", Offset = "0x1739FB8", VA = "0x1739FB8", Slot = "32")]
	protected virtual string GetNormalBtnSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600A390")]
	[Address(RVA = "0x173A05C", Offset = "0x173A05C", VA = "0x173A05C", Slot = "33")]
	protected virtual UIAtlas GetGuideBtnSpriteAtlas()
	{
		return null;
	}

	[Token(Token = "0x600A391")]
	[Address(RVA = "0x173A0B4", Offset = "0x173A0B4", VA = "0x173A0B4", Slot = "34")]
	protected virtual UIAtlas GetNormalBtnSpriteAtlas()
	{
		return null;
	}

	[Token(Token = "0x600A392")]
	[Address(RVA = "0x173A10C", Offset = "0x173A10C", VA = "0x173A10C")]
	public void AdjustBtnStyle(bool GuideOnLeft = false)
	{
	}

	[Token(Token = "0x600A393")]
	[Address(RVA = "0x173A630", Offset = "0x173A630", VA = "0x173A630")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
