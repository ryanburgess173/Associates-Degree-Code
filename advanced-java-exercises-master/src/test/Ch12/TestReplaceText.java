package test.Ch12;

import main.Listings.Ch12.ReplaceText;

public class TestReplaceText {
    private String[] args = new String[4];
    public TestReplaceText() throws Exception {
        this.args[0] = "scores.txt";
        this.args[1] = "scores2.txt";
        this.args[2] = "John";
        this.args[3] = "Ryan";
        ReplaceText rt = new ReplaceText(this.args);
    }
}
