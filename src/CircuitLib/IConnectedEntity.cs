using System.Collections.Generic;

namespace TfmrLib;

public interface IConnectedEntity
{
    IReadOnlyList<Node> Terminals { get; }

    void RepointTerminal(Node oldNode, Node newNode);
}