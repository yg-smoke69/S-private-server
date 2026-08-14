using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040F5")]
public interface IResourceRefCacheWithOwner
{
	[Token(Token = "0x601A802")]
	void Clear();

	[Token(Token = "0x601A803")]
	Object TryGet(ResourceID resId);

	[Token(Token = "0x601A804")]
	Object GetAndRegister(object owner, ResourceID resId);

	[Token(Token = "0x601A805")]
	void Register(object owner, Object res);

	[Token(Token = "0x601A806")]
	void UnRegister(object owner, Object res);

	[Token(Token = "0x601A807")]
	void UnRegisterAll(object owner);

	[Token(Token = "0x601A808")]
	bool HasUnRefedRes();

	[Token(Token = "0x601A809")]
	bool UnloadOneUnRefedRes();

	[Token(Token = "0x601A80A")]
	int UnloadAllUnRefedRes();

	[Token(Token = "0x601A80B")]
	bool IsAsyncLoading();

	[Token(Token = "0x601A80C")]
	bool IsAsyncLoading(object owner, ResourceID resId);

	[Token(Token = "0x601A80D")]
	uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, Object> callback);

	[Token(Token = "0x601A80E")]
	void CancelAsync(object owner, uint ticket);

	[Token(Token = "0x601A80F")]
	void CancelAsyncs(object owner);

	[Token(Token = "0x601A810")]
	void CancelAllAsyncs();

	[Token(Token = "0x601A811")]
	void RemoveOwner(object owner);
}
