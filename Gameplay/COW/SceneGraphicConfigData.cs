using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000229")]
public class SceneGraphicConfigData : SingletonModule<SceneGraphicConfigData>
{
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, SceneGraphicConfigItem> m_SceneConfigDic;

	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x20DD664", Offset = "0x20DD664", VA = "0x20DD664")]
	public SceneGraphicConfigData()
	{
	}

	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x20DD728", Offset = "0x20DD728", VA = "0x20DD728", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x20DDF9C", Offset = "0x20DDF9C", VA = "0x20DDF9C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x20DD788", Offset = "0x20DD788", VA = "0x20DD788")]
	private void LoadDataFromConfig()
	{
	}

	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x20DE06C", Offset = "0x20DE06C", VA = "0x20DE06C")]
	public SceneGraphicConfigItem GetSceneGraphicConfig(string sceneName)
	{
		return null;
	}
}
