using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E00")]
internal class OptionalBundleDataManager : SingletonModule<OptionalBundleDataManager>
{
	[Token(Token = "0x601346F")]
	[Address(RVA = "0x28C8E40", Offset = "0x28C8E40", VA = "0x28C8E40")]
	public OptionalBundleDataManager()
	{
	}

	[Token(Token = "0x6013470")]
	[Address(RVA = "0x28C8ED0", Offset = "0x28C8ED0", VA = "0x28C8ED0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013471")]
	[Address(RVA = "0x28C8F30", Offset = "0x28C8F30", VA = "0x28C8F30")]
	public void LoadLocalOptionalBundleData()
	{
	}

	[Token(Token = "0x6013472")]
	[Address(RVA = "0x28C90EC", Offset = "0x28C90EC", VA = "0x28C90EC")]
	public List<OptionalDownloadLogSettingData> LoadOptionalBundleDownloadLogConfig()
	{
		return null;
	}

	[Token(Token = "0x6013473")]
	[Address(RVA = "0x28C920C", Offset = "0x28C920C", VA = "0x28C920C", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
