using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032F9")]
public class PreviewParticleDataManager : SingletonModule<PreviewParticleDataManager>
{
	[Token(Token = "0x40135F9")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, PreviewParticleData> m_dictIdToCSItemPreviewParticleData;

	[Token(Token = "0x60157D0")]
	[Address(RVA = "0x195C264", Offset = "0x195C264", VA = "0x195C264")]
	public PreviewParticleDataManager()
	{
	}

	[Token(Token = "0x60157D1")]
	[Address(RVA = "0x195C328", Offset = "0x195C328", VA = "0x195C328", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60157D2")]
	[Address(RVA = "0x195C3F0", Offset = "0x195C3F0", VA = "0x195C3F0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60157D3")]
	[Address(RVA = "0x195C63C", Offset = "0x195C63C", VA = "0x195C63C")]
	public PreviewParticleData FindPreviewParticleDataById(int InId)
	{
		return null;
	}
}
