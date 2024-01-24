package test.Ch12;

import main.Listings.Ch12.WriteData;

import java.io.IOException;

public class TestWriteData {

    private WriteData wd;

    public TestWriteData() throws IOException {
        this.wd = new WriteData();
        this.wd.displayOutput();
        this.wd.closeOutput();
    }

}
