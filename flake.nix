{
  description = "Backend oppgave - Temperature Advisor development environment";

  inputs = {
    nixpkgs.url = "github:NixOS/nixpkgs/nixos-unstable";
    flake-utils.url = "github:numtide/flake-utils";
  };

  outputs = { self, nixpkgs, flake-utils }:
    flake-utils.lib.eachDefaultSystem (system:
      let
        pkgs = import nixpkgs { inherit system; };
      in
      {
        devShells.default = pkgs.mkShell {
          buildInputs = [
            pkgs.dotnet-sdk_9
            # Optional: Add other tools you might need
            # pkgs.git
            # pkgs.omnisharp-roslyn  # C# language server
          ];
          
          shellHook = ''
            echo "================================="
            echo "   Temperature Advisor 6000   "
            echo "   Development Environment"
            echo "================================="
            echo ""
            echo "Available commands:"
            echo "  dotnet --version    - Check .NET version"
            echo "  dotnet build        - Build the project"
            echo "  dotnet run          - Run the project"
            echo ""
          '';
        };
      }
    );
}