using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C7C")]
public interface ISlotOverlayRefs
{
	[Token(Token = "0x60182A5")]
	bool HasRefs();

	[Token(Token = "0x60182A6")]
	void ClearRefs();

	[Token(Token = "0x60182A7")]
	short AddRefCount(bool isSlot, Object asset, short deltaCount);

	[Token(Token = "0x60182A8")]
	void GetRefedAssets(ICollection<SlotDataAsset> slots, ICollection<OverlayDataAsset> overlays);

	[Token(Token = "0x60182A9")]
	void PrintCacheRefs(StreamWriter sw);
}
