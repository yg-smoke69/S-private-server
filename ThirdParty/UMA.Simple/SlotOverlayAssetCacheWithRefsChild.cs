using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C7A")]
public class SlotOverlayAssetCacheWithRefsChild : SlotOverlayAssetCacheWithRefs
{
	[Token(Token = "0x4019B27")]
	[FieldOffset(Offset = "0x48")]
	protected SlotOverlayAssetCacheWithRefsDic m_Root;

	[Token(Token = "0x4019B28")]
	[FieldOffset(Offset = "0x4C")]
	private SlotOverlayRefsSet _003CRefsSet_003Ek__BackingField;

	[Token(Token = "0x1700199E")]
	public SlotOverlayRefsSet RefsSet
	{
		[Token(Token = "0x6018272")]
		[Address(RVA = "0x2D5AEF4", Offset = "0x2D5AEF4", VA = "0x2D5AEF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018273")]
		[Address(RVA = "0x2D5AEFC", Offset = "0x2D5AEFC", VA = "0x2D5AEFC")]
		protected set
		{
		}
	}

	[Token(Token = "0x6018271")]
	[Address(RVA = "0x2D5AED4", Offset = "0x2D5AED4", VA = "0x2D5AED4")]
	public SlotOverlayAssetCacheWithRefsChild(SlotOverlayAssetCacheWithRefsDic root)
	{
	}

	[Token(Token = "0x6018274")]
	[Address(RVA = "0x2D5AF04", Offset = "0x2D5AF04", VA = "0x2D5AF04", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6018275")]
	[Address(RVA = "0x2D5B04C", Offset = "0x2D5B04C", VA = "0x2D5B04C")]
	private void SetCaches(SlotOverlayAssetCacheData c)
	{
	}

	[Token(Token = "0x6018276")]
	[Address(RVA = "0x2D5B0EC", Offset = "0x2D5B0EC", VA = "0x2D5B0EC", Slot = "14")]
	protected override void InitRefs()
	{
	}

	[Token(Token = "0x6018277")]
	[Address(RVA = "0x2D5B21C", Offset = "0x2D5B21C", VA = "0x2D5B21C", Slot = "5")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6018278")]
	[Address(RVA = "0x2D5B22C", Offset = "0x2D5B22C", VA = "0x2D5B22C")]
	public void ReleaseRefs(bool removeCachedAsset)
	{
	}

	[Token(Token = "0x6018279")]
	[Address(RVA = "0x2D5B910", Offset = "0x2D5B910", VA = "0x2D5B910", Slot = "16")]
	protected override void AddRefCountChecked(int nameHash, bool isSlot, Object asset, bool alreadyInCache, bool preload)
	{
	}
}
