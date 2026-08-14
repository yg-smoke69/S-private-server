using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040E4")]
public interface IReusableObjectOwner
{
	[Token(Token = "0x601A71B")]
	void OnReusableObjectRecycled(ResourceID rID, GameObject obj);
}
