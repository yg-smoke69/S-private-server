using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000C8C")]
public class MusicElementEditAttributeConfig : ItemEditAttributeBaseConfig
{
	[Token(Token = "0x4006707")]
	[FieldOffset(Offset = "0xC")]
	public string MusicElementTitleNameKey;

	[Token(Token = "0x4006708")]
	[FieldOffset(Offset = "0x10")]
	public List<int> KeyIDs;

	[Token(Token = "0x4006709")]
	[FieldOffset(Offset = "0x14")]
	public List<string> KeyName;

	[Token(Token = "0x6006003")]
	[Address(RVA = "0x1166F20", Offset = "0x1166F20", VA = "0x1166F20")]
	public MusicElementEditAttributeConfig()
	{
	}

	[Token(Token = "0x6006004")]
	[Address(RVA = "0x1166FE0", Offset = "0x1166FE0", VA = "0x1166FE0")]
	public List<ItemEditAttributeUIData> HEJHOBDAKPC(SceneEditObjectMusicElement CGDAFHNPMFB)
	{
		return null;
	}

	[Token(Token = "0x6006005")]
	[Address(RVA = "0x1167364", Offset = "0x1167364", VA = "0x1167364", Slot = "4")]
	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x6006006")]
	[Address(RVA = "0x11673C8", Offset = "0x11673C8", VA = "0x11673C8", Slot = "5")]
	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase CGDAFHNPMFB)
	{
		return null;
	}

	[Token(Token = "0x6006007")]
	[Address(RVA = "0x11674E4", Offset = "0x11674E4", VA = "0x11674E4", Slot = "6")]
	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase CGDAFHNPMFB, List<ItemEditAttributeCacheValueBase> KOLGKDOGOIE)
	{
	}

	[Token(Token = "0x6006008")]
	[Address(RVA = "0x1167750", Offset = "0x1167750", VA = "0x1167750", Slot = "7")]
	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase LMICHPEENDG, List<ItemEditAttributeCacheValueBase> KOLGKDOGOIE)
	{
	}

	[Token(Token = "0x6006009")]
	[Address(RVA = "0x1167948", Offset = "0x1167948", VA = "0x1167948")]
	public List<ItemEditAttributeUIData> _003C_003EiFixBaseProxy_GetDefaultUIData()
	{
		return null;
	}

	[Token(Token = "0x600600A")]
	[Address(RVA = "0x1167950", Offset = "0x1167950", VA = "0x1167950")]
	public List<ItemEditAttributeUIData> _003C_003EiFixBaseProxy_GetSceneEditObjectUIData(SceneEditObjectBase P0)
	{
		return null;
	}

	[Token(Token = "0x600600B")]
	[Address(RVA = "0x1167958", Offset = "0x1167958", VA = "0x1167958")]
	public void _003C_003EiFixBaseProxy_ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase P0, List<ItemEditAttributeCacheValueBase> P1)
	{
	}

	[Token(Token = "0x600600C")]
	[Address(RVA = "0x1167960", Offset = "0x1167960", VA = "0x1167960")]
	public void _003C_003EiFixBaseProxy_ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase P0, List<ItemEditAttributeCacheValueBase> P1)
	{
	}
}
