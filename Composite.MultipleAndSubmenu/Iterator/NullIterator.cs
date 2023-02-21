using System.Collections;
using Composite.MultipleAndSubmenu.Menu;

namespace Composite.MultipleAndSubmenu.Iterator;

public class NullIterator : IEnumerator<MenuComponent>
{
    public bool MoveNext() => false;

    public void Reset() { }

    public MenuComponent Current => null;

    object IEnumerator.Current => Current;

    public void Dispose() { }
}