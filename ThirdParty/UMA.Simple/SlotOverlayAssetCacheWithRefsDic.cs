using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C79")]
public class SlotOverlayAssetCacheWithRefsDic : SlotOverlayAssetCacheWithRefs
{
	[Token(Token = "0x4019B26")]
	[FieldOffset(Offset = "0x48")]
	private SlotOverlayRefsDic _003CRefsDic_003Ek__BackingField;

	[Token(Token = "0x1700199D")]
	public SlotOverlayRefsDic RefsDic
	{
		[Token(Token = "0x601826A")]
		[Address(RVA = "0x2D5CED0", Offset = "0x2D5CED0", VA = "0x2D5CED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x601826B")]
		[Address(RVA = "0x2D5CED8", Offset = "0x2D5CED8", VA = "0x2D5CED8")]
		protected set
		{
		}
	}

	[Token(Token = "0x6018269")]
	[Address(RVA = "0x2D5CEC8", Offset = "0x2D5CEC8", VA = "0x2D5CEC8")]
	public SlotOverlayAssetCacheWithRefsDic()
	{
	}

	[Token(Token = "0x601826C")]
	[Address(RVA = "0x2D5CEE0", Offset = "0x2D5CEE0", VA = "0x2D5CEE0", Slot = "14")]
	protected override void InitRefs()
	{
	}

	[Token(Token = "0x601826D")]
	[Address(RVA = "0x2D5AF50", Offset = "0x2D5AF50", VA = "0x2D5AF50")]
	public SlotOverlayAssetCacheData GetCaches()
	{
		return null;
	}

	[Token(Token = "0x601826E")]
	[Address(RVA = "0x2D5D010", Offset = "0x2D5D010", VA = "0x2D5D010", Slot = "16")]
	protected override void AddRefCountChecked(int nameHash, bool isSlot, Object asset, bool alreadyInCache, bool preload)
	{
	}

	[Token(Token = "0x601826F")]
	[Address(RVA = "0x2D5D680", Offset = "0x2D5D680", VA = "0x2D5D680")]
	public void TouchRefCount(bool isSlot, Object asset)
	{
	}

	[Token(Token = "0x6018270")]
	[Address(RVA = "0x2D5B6BC", Offset = "0x2D5B6BC", VA = "0x2D5B6BC")]
	public bool DecreaseRefCount(bool isSlot, Object asset, bool removeOnZero)
	{
		return default(bool);
	}
}
