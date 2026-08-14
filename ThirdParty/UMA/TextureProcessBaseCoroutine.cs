using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x2003CBF")]
public abstract class TextureProcessBaseCoroutine : WorkerCoroutine
{
	[Token(Token = "0x60184ED")]
	[Address(RVA = "0x2DF31D4", Offset = "0x2DF31D4", VA = "0x2DF31D4")]
	protected TextureProcessBaseCoroutine()
	{
	}

	[Token(Token = "0x60184EE")]
	public abstract void Prepare(UMAData _umaData, UMAGeneratorBase _umaGenerator);
}
