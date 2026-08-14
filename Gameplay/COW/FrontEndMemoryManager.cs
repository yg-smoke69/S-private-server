using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DE2")]
public class FrontEndMemoryManager : SingletonModule<FrontEndMemoryManager>
{
	[Token(Token = "0x40119B8")]
	[FieldOffset(Offset = "0xC")]
	private int loadedCDNCount;

	[Token(Token = "0x40119B9")]
	[FieldOffset(Offset = "0x10")]
	private int loadedCGCount;

	[Token(Token = "0x40119BA")]
	[FieldOffset(Offset = "0x14")]
	private int loadedUMACount;

	[Token(Token = "0x40119BB")]
	[FieldOffset(Offset = "0x18")]
	private int loadedPreview3dModelCount;

	[Token(Token = "0x40119BC")]
	private const int lowMemoryThreshold = 150;

	[Token(Token = "0x60133B6")]
	[Address(RVA = "0xDFA424", Offset = "0xDFA424", VA = "0xDFA424")]
	public FrontEndMemoryManager()
	{
	}

	[Token(Token = "0x60133B7")]
	[Address(RVA = "0xDFA4B4", Offset = "0xDFA4B4", VA = "0xDFA4B4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60133B8")]
	[Address(RVA = "0xDFA518", Offset = "0xDFA518", VA = "0xDFA518", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60133B9")]
	[Address(RVA = "0xDFA63C", Offset = "0xDFA63C", VA = "0xDFA63C")]
	public void OnLoadCDN(int count)
	{
	}

	[Token(Token = "0x60133BA")]
	[Address(RVA = "0xDFA884", Offset = "0xDFA884", VA = "0xDFA884")]
	public void OnLoadCGCount(int count)
	{
	}

	[Token(Token = "0x60133BB")]
	[Address(RVA = "0xDFA980", Offset = "0xDFA980", VA = "0xDFA980")]
	public void OnLoadUMACount(int count)
	{
	}

	[Token(Token = "0x60133BC")]
	[Address(RVA = "0xDFAA7C", Offset = "0xDFAA7C", VA = "0xDFAA7C")]
	public void OnLoadPreview3dModel(int count)
	{
	}

	[Token(Token = "0x60133BD")]
	[Address(RVA = "0xDFA738", Offset = "0xDFA738", VA = "0xDFA738")]
	public void TryClearMemory()
	{
	}

	[Token(Token = "0x60133BE")]
	[Address(RVA = "0xDFAB78", Offset = "0xDFAB78", VA = "0xDFAB78")]
	public void ClearUnusedAssets(bool uma = true, bool bTryCleanupFor32bitAndroid = false, bool bForceCleanup = false)
	{
	}

	[Token(Token = "0x60133BF")]
	[Address(RVA = "0xDFAE68", Offset = "0xDFAE68", VA = "0xDFAE68")]
	public bool SkipGachaFullCG()
	{
		return default(bool);
	}
}
