using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000146")]
public class GraphicQualityConfigData : SingletonModule<GraphicQualityConfigData>
{
	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, Dictionary<int, GraphicConfigItem>> m_QualityConfigDic;

	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0x10")]
	private GraphicConfigItem defaultGraphicConfigItems;

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x2594934", Offset = "0x2594934", VA = "0x2594934")]
	public GraphicQualityConfigData()
	{
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x25949F8", Offset = "0x25949F8", VA = "0x25949F8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x2596288", Offset = "0x2596288", VA = "0x2596288", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x2594A58", Offset = "0x2594A58", VA = "0x2594A58")]
	private void LoadDataFromConfig()
	{
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x2596348", Offset = "0x2596348", VA = "0x2596348")]
	public GraphicConfigItem GetCurrentConfig()
	{
		return null;
	}
}
